using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 奈狄这周上了多少班_
{
    public partial class Form_Main : Form
    {
        #region ======== Build ========

        public Form_Main()
        {
            InitializeComponent();
        }

        #endregion

        #region ======== Event ========

        private void Form_Main_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            States state = NowState(now);

            Timer_Realtime.Interval = 1000;
            Timer_Realtime.Tick += Ticking;
            Timer_Realtime.Start();
        }
        private void Button_CopyToday_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Label_TodayValue.Text.Replace(" ", ""));
        }

        private void Button_CopyWeek_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Label_WeekValue.Text.Replace(" ", ""));
        }

        private void Button_Config_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region ======== Property ========

        private static TimeSpan Wakeup => new(6, 30, 0);
        private static TimeSpan Forenoon => new(8, 0, 0);
        private static TimeSpan Lunch => new(11, 50, 0);
        private static TimeSpan Snap => new(12, 20, 0);
        private static TimeSpan Afternoon => new(13, 30, 0);
        private static TimeSpan Notyet => new(16, 30, 0);
        private static TimeSpan Rest => new(17, 30, 0);
        private static TimeSpan Wakedown => new(23, 30, 0);

        private States State { get; set; } = States.Initial;

        #endregion

        #region ======== Method ========

        private void Ticking(object? sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            States state = NowState(now);

            UpdateTime(now);
            if (state != State)
                UpdateStatus(now, state);
            if (state == States.Forenoon || state == States.Notyet || state == States.Afternoon)
                UpdateProgress(now, state);
        }

        private States NowState(DateTime now)
        {
            if (now.TimeOfDay >= Wakedown || now.TimeOfDay < Wakeup)
                return States.Wakedown;
            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
                return States.Weekend;
            if (now.TimeOfDay >= Rest)
                return States.Rest;
            if (now.TimeOfDay >= Notyet)
                return States.Notyet;
            if (now.TimeOfDay >= Afternoon)
                return States.Afternoon;
            if (now.TimeOfDay >= Snap)
                return States.Snap;
            if (now.TimeOfDay >= Lunch)
                return States.Lunch;
            if (now.TimeOfDay >= Forenoon)
                return States.Forenoon;
            if (now.TimeOfDay >= Wakeup)
                return States.Wakeup;
            return States.Initial;
        }

        private void UpdateTime(DateTime now)
        {
            Label_Realtime.Text = now.ToString("yyyy-MM-dd HH:mm:ss");
            Label_Weekday.Text = now.DayOfWeek switch
            {
                DayOfWeek.Monday => "星期一",
                DayOfWeek.Tuesday => "星期二",
                DayOfWeek.Wednesday => "星期三",
                DayOfWeek.Thursday => "星期四",
                DayOfWeek.Friday => "星期五",
                DayOfWeek.Saturday => "星期六",
                DayOfWeek.Sunday => "星期天",
                _ => throw new Exception()
            };
        }

        private void UpdateStatus(DateTime now, States state)
        {
            State = state;
            Label_Status.Text = state switch
            {
                States.Wakeup => "还没上班",
                States.Forenoon => "正在上班",
                States.Lunch => "正在进食",
                States.Snap => "正在打盹",
                States.Afternoon => "正在上班",
                States.Notyet => "还没下班",
                States.Rest => "下班时刻",
                States.Wakedown => "正在昏睡",
                States.Weekend => "不用上班",
                _ => "在干什么"
            };
            PictureBox_Mood.Image = state switch
            {
                States.Wakeup => Res.wld1,
                States.Forenoon => Res.wld2,
                States.Lunch => Res.nyd2,
                States.Snap => Res.wld3,
                States.Afternoon => Res.wld2,
                States.Notyet => Res.nyd1,
                States.Rest => Res.crl,
                States.Wakedown => Res.wld3,
                States.Weekend => Res.cc,
                _ => Res.nyd4
            };

            int dayOfWeek = (int)now.DayOfWeek != 0 ? (int)now.DayOfWeek : 7;
            if (dayOfWeek >= 6)
            {
                Label_TodayValue.Text = "-------  /  -";
                Label_WeekValue.Text = "-------  /  -";
                ProgressBar_Today1.Value = ProgressBar_Today1.Minimum;
                ProgressBar_Today2.Value = ProgressBar_Today2.Minimum;
                ProgressBar_Week1.Value = ProgressBar_Week1.Maximum;
                ProgressBar_Week2.Value = ProgressBar_Week2.Maximum;
                ProgressBar_Week3.Value = ProgressBar_Week3.Maximum;
                ProgressBar_Week4.Value = ProgressBar_Week4.Maximum;
                ProgressBar_Week5.Value = ProgressBar_Week5.Maximum;
            }
            else
            {
                Label_TodayValue.Text =
                    now.TimeOfDay < Lunch ? "0        /  1" :
                    now.TimeOfDay < Rest ? "0.5      /  1" :
                    "1        /  1";
                ProgressBar_Today1.Value = now.TimeOfDay < Lunch ? ProgressBar_Today1.Minimum : ProgressBar_Today1.Maximum;
                ProgressBar_Today2.Value = now.TimeOfDay < Rest ? ProgressBar_Today2.Minimum : ProgressBar_Today2.Maximum;
                Label_WeekValue.Text =
                    (dayOfWeek == 1 && now.TimeOfDay < Lunch) ? "0        /  5" :
                    (dayOfWeek == 1 && now.TimeOfDay < Rest) ? "0.5      /  5" :
                    (dayOfWeek == 1 || dayOfWeek == 2 && now.TimeOfDay < Lunch) ? "1        /  5" :
                    (dayOfWeek == 2 && now.TimeOfDay < Rest) ? "1.5      /  5" :
                    (dayOfWeek == 2 || dayOfWeek == 3 && now.TimeOfDay < Lunch) ? "2        /  5" :
                    (dayOfWeek == 3 && now.TimeOfDay < Rest) ? "2.5      /  5" :
                    (dayOfWeek == 3 || dayOfWeek == 4 && now.TimeOfDay < Lunch) ? "3        /  5" :
                    (dayOfWeek == 4 && now.TimeOfDay < Rest) ? "3.5      /  5" :
                    (dayOfWeek == 4 || dayOfWeek == 5 && now.TimeOfDay < Lunch) ? "4        /  5" :
                    (dayOfWeek == 5 && now.TimeOfDay < Rest) ? "4.5      /  5" : "5        /  5";
                ProgressBar_Week1.Value =
                    (dayOfWeek < 1 || dayOfWeek == 1 && now.TimeOfDay < Lunch) ? ProgressBar_Week1.Minimum :
                    (dayOfWeek == 1 && now.TimeOfDay < Rest) ? ProgressBar_Week1.Maximum / 2 :
                    ProgressBar_Week1.Maximum;
                ProgressBar_Week2.Value =
                    (dayOfWeek < 2 || dayOfWeek == 2 && now.TimeOfDay < Lunch) ? ProgressBar_Week2.Minimum :
                    (dayOfWeek == 2 && now.TimeOfDay < Rest) ? ProgressBar_Week1.Maximum / 2 :
                    ProgressBar_Week2.Maximum;
                ProgressBar_Week3.Value =
                    (dayOfWeek < 3 || dayOfWeek == 3 && now.TimeOfDay < Lunch) ? ProgressBar_Week3.Minimum :
                    (dayOfWeek == 3 && now.TimeOfDay < Rest) ? ProgressBar_Week1.Maximum / 2 :
                    ProgressBar_Week3.Maximum;
                ProgressBar_Week4.Value =
                    (dayOfWeek < 4 || dayOfWeek == 4 && now.TimeOfDay < Lunch) ? ProgressBar_Week4.Minimum :
                    (dayOfWeek == 4 && now.TimeOfDay < Rest) ? ProgressBar_Week1.Maximum / 2 :
                    ProgressBar_Week4.Maximum;
                ProgressBar_Week5.Value =
                    (dayOfWeek < 5 || dayOfWeek == 5 && now.TimeOfDay < Lunch) ? ProgressBar_Week5.Minimum :
                    (dayOfWeek == 5 && now.TimeOfDay < Rest) ? ProgressBar_Week1.Maximum / 2 :
                    ProgressBar_Week5.Maximum;
            }
        }

        private void UpdateProgress(DateTime now, States state)
        {
            int dayTotal = 0;
            if (state == States.Forenoon)
            {
                ProgressBar_Today1.Value = (int)(now.TimeOfDay - Forenoon).TotalSeconds;
                dayTotal = ProgressBar_Today1.Value * 24;
                Label_TodayValue.Text = $"{(double)ProgressBar_Today1.Value / ProgressBar_Today1.Maximum / 2:0.00000}  /  1";
                switch (now.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        ProgressBar_Week1.Value = dayTotal;
                        Label_WeekValue.Text = $"{(double)ProgressBar_Today1.Value / ProgressBar_Today1.Maximum / 2 + 0:0.00000}  /  5";
                        break;
                    case DayOfWeek.Tuesday:
                        ProgressBar_Week2.Value = dayTotal;
                        Label_WeekValue.Text = $"{(double)ProgressBar_Today1.Value / ProgressBar_Today1.Maximum / 2 + 1:0.00000}  /  5";
                        break;
                    case DayOfWeek.Wednesday:
                        ProgressBar_Week3.Value = dayTotal;
                        Label_WeekValue.Text = $"{(double)ProgressBar_Today1.Value / ProgressBar_Today1.Maximum / 2 + 2:0.00000}  /  5";
                        break;
                    case DayOfWeek.Thursday:
                        ProgressBar_Week4.Value = dayTotal;
                        Label_WeekValue.Text = $"{(double)ProgressBar_Today1.Value / ProgressBar_Today1.Maximum / 2 + 3:0.00000}  /  5";
                        break;
                    case DayOfWeek.Friday:
                        ProgressBar_Week5.Value = dayTotal;
                        Label_WeekValue.Text = $"{(double)ProgressBar_Today1.Value / ProgressBar_Today1.Maximum / 2 + 4:0.00000}  /  5";
                        break;
                }
            }
            else
            {
                ProgressBar_Today2.Value = (int)(now.TimeOfDay - Afternoon).TotalSeconds;
                dayTotal = ProgressBar_Today1.Value * 24 + ProgressBar_Today2.Value * 23;
                Label_TodayValue.Text = $"{(double)ProgressBar_Today2.Value / ProgressBar_Today2.Maximum / 2 + 0.5:0.00000}  /  1";
                switch (now.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        ProgressBar_Week1.Value = dayTotal;
                        Label_WeekValue.Text = $"{(double)ProgressBar_Today2.Value / ProgressBar_Today2.Maximum / 2 + 0.5:0.00000}  /  5";
                        break;
                    case DayOfWeek.Tuesday:
                        ProgressBar_Week2.Value = dayTotal;
                        Label_WeekValue.Text = $"{(double)ProgressBar_Today2.Value / ProgressBar_Today2.Maximum / 2 + 1.5:0.00000}  /  5";
                        break;
                    case DayOfWeek.Wednesday:
                        ProgressBar_Week3.Value = dayTotal;
                        Label_WeekValue.Text = $"{(double)ProgressBar_Today2.Value / ProgressBar_Today2.Maximum / 2 + 2.5:0.00000}  /  5";
                        break;
                    case DayOfWeek.Thursday:
                        ProgressBar_Week4.Value = dayTotal;
                        Label_WeekValue.Text = $"{(double)ProgressBar_Today2.Value / ProgressBar_Today2.Maximum / 2 + 3.5:0.00000}  /  5";
                        break;
                    case DayOfWeek.Friday:
                        ProgressBar_Week5.Value = dayTotal;
                        Label_WeekValue.Text = $"{(double)ProgressBar_Today2.Value / ProgressBar_Today2.Maximum / 2 + 4.5:0.00000}  /  5";
                        break;
                }
            }
        }

        #endregion
    }
}