using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace FitnessCenterManagement.userControls
{
    // شاشة الداشبورد - كروت الأرقام ورسم الحضور ودائرة الاشتراكات
    public partial class DashboardUserControl : UserControl
    {
        // حضور آخر 7 أيام - من السبت للجمعة، نفس أرقام الصورة
        private readonly int[] _attendance = { 22, 33, 38, 28, 43, 46, 40 };
        private readonly string[] _days = { "Sat", "Sun", "Mon", "Tue", "Wed", "Thu", "Fri" };

        // اشتراكات الصورة: 201 نشط و 47 منتهي
        private const int ActiveSubscriptions = 201;
        private const int ExpiredSubscriptions = 47;

        public DashboardUserControl() : this("Admin")
        {
        }

        public DashboardUserControl(string userName)
        {
            InitializeComponent();

            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = "Admin";
            }

            // جملة الترحيب - اسم المستخدم اللي داخل
            lblWelcome.Text = "Welcome, " + userName;

            // رسم أعمدة الحضور
            panelBars.Paint += PanelBars_Paint;
            panelBars.Resize += (_, _) => panelBars.Invalidate();

            // رسم دائرة الاشتراكات
            panelDonut.Paint += PanelDonut_Paint;
            panelDonut.Resize += (_, _) => panelDonut.Invalidate();

            RoundCards();
            cardMembers.Resize += (_, _) => Round(cardMembers);
            cardTrainers.Resize += (_, _) => Round(cardTrainers);
            cardSubscriptions.Resize += (_, _) => Round(cardSubscriptions);
            cardCheckIns.Resize += (_, _) => Round(cardCheckIns);
            panelBars.Resize += (_, _) => Round(panelBars);
            panelDonut.Resize += (_, _) => Round(panelDonut);
            Circle(panelIconMembers);
            Circle(panelIconTrainers);
            Circle(panelIconSubscriptions);
            Circle(panelIconCheckIns);
        }

        // تدوير حواف الكروت الأربعة والرسمين
        private void RoundCards()
        {
            Round(cardMembers);
            Round(cardTrainers);
            Round(cardSubscriptions);
            Round(cardCheckIns);
            Round(panelBars);
            Round(panelDonut);
        }

        // حواف دائرية للكارت
        private static void Round(Panel panel)
        {
            if (panel.Width < 20 || panel.Height < 20)
            {
                return;
            }

            int radius = 18;
            using GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius - 1, panel.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius - 1, radius, radius, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        // أيقونة الكارت تبقى دايرة
        private static void Circle(Panel panel)
        {
            using GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, panel.Width - 1, panel.Height - 1);
            panel.Region = new Region(path);
        }

        // رسم أعمدة الحضور لآخر 7 أيام
        private void PanelBars_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            using Font titleFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            using Font axisFont = new Font("Segoe UI", 8.5F);
            using Brush titleBrush = new SolidBrush(Color.FromArgb(15, 23, 42));
            using Brush labelBrush = new SolidBrush(Color.FromArgb(148, 163, 184));
            using Brush barBrush = new SolidBrush(Color.FromArgb(59, 130, 246));
            using Pen gridPen = new Pen(Color.FromArgb(226, 232, 240));

            g.DrawString("Attendance (Last 7 Days)", titleFont, titleBrush, 18, 16);

            int left = 52;
            int right = panelBars.Width - 28;
            int top = 64;
            int bottom = panelBars.Height - 40;
            int max = 50;

            if (right <= left || bottom <= top)
            {
                return;
            }

            for (int value = 0; value <= max; value += 10)
            {
                float y = bottom - (value / (float)max) * (bottom - top);
                g.DrawLine(gridPen, left, y, right, y);
                string text = value.ToString();
                SizeF size = g.MeasureString(text, axisFont);
                g.DrawString(text, axisFont, labelBrush, left - size.Width - 8, y - size.Height / 2);
            }

            float slot = (right - left) / (float)_attendance.Length;
            float barWidth = slot * 0.42f;

            for (int i = 0; i < _attendance.Length; i++)
            {
                float barHeight = _attendance[i] / (float)max * (bottom - top);
                float x = left + (slot * i) + ((slot - barWidth) / 2f);
                float y = bottom - barHeight;

                using GraphicsPath bar = RoundedTop((int)x, (int)y, (int)barWidth, (int)barHeight, 7);
                g.FillPath(barBrush, bar);

                SizeF daySize = g.MeasureString(_days[i], axisFont);
                g.DrawString(_days[i], axisFont, labelBrush, x + (barWidth / 2f) - (daySize.Width / 2f), bottom + 8);
            }
        }

        // عمود بحواف علوية دائرية
        private static GraphicsPath RoundedTop(int x, int y, int width, int height, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            if (width <= 2 || height <= 2)
            {
                path.AddRectangle(new Rectangle(x, y, Math.Max(width, 1), Math.Max(height, 1)));
                return path;
            }

            if (radius * 2 > width)
            {
                radius = width / 2;
            }

            if (radius * 2 > height)
            {
                radius = height / 2;
            }

            path.AddArc(x, y, radius * 2, radius * 2, 180, 90);
            path.AddArc(x + width - (radius * 2), y, radius * 2, radius * 2, 270, 90);
            path.AddLine(x + width, y + height, x, y + height);
            path.CloseFigure();
            return path;
        }

        // رسم دائرة الاشتراكات: الأخضر نشط والأحمر منتهي
        private void PanelDonut_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            int total = ActiveSubscriptions + ExpiredSubscriptions;
            int activePercent = (int)Math.Round(ActiveSubscriptions * 100.0 / total);
            int expiredPercent = 100 - activePercent;

            using Font titleFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            using Font valueFont = new Font("Segoe UI", 18F, FontStyle.Bold);
            using Font smallFont = new Font("Segoe UI", 9F);
            using Brush titleBrush = new SolidBrush(Color.FromArgb(15, 23, 42));
            using Brush mutedBrush = new SolidBrush(Color.FromArgb(100, 116, 139));
            using Brush green = new SolidBrush(Color.FromArgb(34, 197, 94));
            using Brush red = new SolidBrush(Color.FromArgb(239, 68, 68));

            g.DrawString("Subscriptions", titleFont, titleBrush, 18, 16);

            int legendHeight = 72;
            int size = Math.Min(panelDonut.Width - 70, panelDonut.Height - 70 - legendHeight);
            if (size < 40)
            {
                return;
            }

            int centerX = panelDonut.Width / 2;
            int centerY = 48 + (size / 2);
            Rectangle pie = new Rectangle(centerX - (size / 2), centerY - (size / 2), size, size);
            float greenSweep = ActiveSubscriptions * 360f / total;

            g.FillPie(green, pie, 210, greenSweep);
            g.FillPie(red, pie, 210 + greenSweep, 360f - greenSweep);

            int hole = (int)(size * 0.64f);
            g.FillEllipse(Brushes.White, centerX - (hole / 2), centerY - (hole / 2), hole, hole);

            string totalText = total.ToString();
            SizeF totalSize = g.MeasureString(totalText, valueFont);
            SizeF membersSize = g.MeasureString("Members", smallFont);
            g.DrawString(totalText, valueFont, titleBrush, centerX - (totalSize.Width / 2f), centerY - totalSize.Height + 4);
            g.DrawString("Members", smallFont, mutedBrush, centerX - (membersSize.Width / 2f), centerY + 2);

            int legendTop = panelDonut.Height - 58;
            DrawLegendRow(g, smallFont, green, "Active (" + ActiveSubscriptions + ")", activePercent + "%", 22, legendTop);
            DrawLegendRow(g, smallFont, red, "Expired (" + ExpiredSubscriptions + ")", expiredPercent + "%", 22, legendTop + 26);
        }

        // سطر في مفتاح الرسم: اللون، الاسم، والنسبة
        private void DrawLegendRow(Graphics g, Font font, Brush color, string name, string percent, int x, int y)
        {
            g.FillEllipse(color, x, y + 3, 10, 10);
            using Brush textBrush = new SolidBrush(Color.FromArgb(51, 65, 85));
            g.DrawString(name, font, textBrush, x + 18, y);
            SizeF percentSize = g.MeasureString(percent, font);
            g.DrawString(percent, font, textBrush, panelDonut.Width - 22 - percentSize.Width, y);
        }
    }
}
