-- Fitness Center Management System | SQL Server schema
-- Run on SQL Server Express / LocalDB. Requires SQL Server 2016+.
IF DB_ID(N'FitnessCenterDB') IS NULL
    CREATE DATABASE FitnessCenterDB;
GO
USE FitnessCenterDB;
GO

CREATE TABLE dbo.Users (
    UserId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(20) NOT NULL CONSTRAINT CK_Users_Role CHECK (Role IN ('Admin','Receptionist')),
    IsActive BIT NOT NULL CONSTRAINT DF_Users_IsActive DEFAULT (1),
    CreatedAt DATETIME2 NOT NULL CONSTRAINT DF_Users_CreatedAt DEFAULT SYSUTCDATETIME()
);

CREATE TABLE dbo.Members (
    MemberId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    FullName NVARCHAR(120) NOT NULL,
    Phone NVARCHAR(20) NOT NULL,
    Email NVARCHAR(150) NULL,
    DateOfBirth DATE NULL,
    Gender NVARCHAR(20) NULL CONSTRAINT CK_Members_Gender CHECK (Gender IN ('Male','Female','Other')),
    JoinDate DATE NOT NULL CONSTRAINT DF_Members_JoinDate DEFAULT CONVERT(DATE, GETDATE()),
    IsActive BIT NOT NULL CONSTRAINT DF_Members_IsActive DEFAULT (1),
    CONSTRAINT UQ_Members_Phone UNIQUE (Phone)
);

CREATE TABLE dbo.Trainers (
    TrainerId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    FullName NVARCHAR(120) NOT NULL,
    Phone NVARCHAR(20) NOT NULL,
    Specialization NVARCHAR(100) NULL,
    HireDate DATE NULL,
    IsActive BIT NOT NULL CONSTRAINT DF_Trainers_IsActive DEFAULT (1),
    CONSTRAINT UQ_Trainers_Phone UNIQUE (Phone)
);

CREATE TABLE dbo.MembershipPlans (
    MembershipPlanId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL UNIQUE,
    DurationDays INT NOT NULL CONSTRAINT CK_MembershipPlans_Duration CHECK (DurationDays > 0),
    Price DECIMAL(10,2) NOT NULL CONSTRAINT CK_MembershipPlans_Price CHECK (Price >= 0),
    IsActive BIT NOT NULL CONSTRAINT DF_MembershipPlans_IsActive DEFAULT (1)
);

CREATE TABLE dbo.Subscriptions (
    SubscriptionId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    MemberId INT NOT NULL,
    MembershipPlanId INT NOT NULL,
    TrainerId INT NULL,
    PaymentMethod NVARCHAR(20) NOT NULL
    CONSTRAINT CK_Subscriptions_PaymentMethod
    CHECK (PaymentMethod IN ('Cash', 'Visa', 'Wallet')),
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    AmountPaid DECIMAL(10,2) NOT NULL CONSTRAINT CK_Subscriptions_Amount CHECK (AmountPaid >= 0),
    CreatedAt DATETIME2 NOT NULL CONSTRAINT DF_Subscriptions_CreatedAt DEFAULT SYSUTCDATETIME(),
    CONSTRAINT FK_Subscriptions_Members FOREIGN KEY (MemberId) REFERENCES dbo.Members(MemberId),
    CONSTRAINT FK_Subscriptions_Trainers FOREIGN KEY (TrainerId) REFERENCES dbo.Trainers(TrainerId),
    CONSTRAINT FK_Subscriptions_MembershipPlans FOREIGN KEY (MembershipPlanId) REFERENCES dbo.MembershipPlans(MembershipPlanId),
    CONSTRAINT CK_Subscriptions_Dates CHECK (EndDate >= StartDate)
);



CREATE TABLE dbo.Attendance (
    AttendanceId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    MemberId INT NOT NULL,
    CheckInTime DATETIME2 NOT NULL CONSTRAINT DF_Attendance_CheckIn DEFAULT SYSDATETIME(),
    CheckOutTime DATETIME2 NULL,
    CONSTRAINT FK_Attendance_Members FOREIGN KEY (MemberId) REFERENCES dbo.Members(MemberId),
    CONSTRAINT CK_Attendance_Times CHECK (CheckOutTime IS NULL OR CheckOutTime >= CheckInTime)
);
GO

-- Only one open check-in for a member at any given time.
CREATE UNIQUE INDEX UX_Attendance_OneOpenCheckIn
ON dbo.Attendance(MemberId)
WHERE CheckOutTime IS NULL;
GO
CREATE INDEX IX_Subscriptions_MemberDates ON dbo.Subscriptions(MemberId, StartDate, EndDate);
CREATE INDEX IX_Attendance_MemberCheckIn ON dbo.Attendance(MemberId, CheckInTime);
GO
-- Business rules enforced by service layer:
-- * No overlapping active date ranges for a member's subscriptions (if desired).
-- * Check-in only when member is active and covered by a valid subscription.
-- * Archive/deactivate members/trainers rather than deleting referenced records.
-- * Derive subscription active/expired from dates, do not store a mutable status.
-- * Hash passwords using a password KDF such as PBKDF2/Argon2id; never plain text.
