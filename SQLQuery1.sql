USE FitnessCenterDB;
GO

INSERT INTO dbo.Users
    (Username, PasswordHash, Role, IsActive)
VALUES
(
    'admin',
    '600000.gWiXcU+FTleip6cBZuC4rA==.TvBj/M5jqFoT5oglTDMJSSoCuDjUhYpmog0M8heApwA=',
    'Admin',
    1
);