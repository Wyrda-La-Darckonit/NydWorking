namespace 奈狄这周上了多少班_
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Label_NowIs = new System.Windows.Forms.Label();
            this.Label_Realtime = new System.Windows.Forms.Label();
            this.Label_Weekday = new System.Windows.Forms.Label();
            this.Label_NydIs = new System.Windows.Forms.Label();
            this.Label_Status = new System.Windows.Forms.Label();
            this.Label_TodayIs = new System.Windows.Forms.Label();
            this.Label_TodayValue = new System.Windows.Forms.Label();
            this.ProgressBar_Today1 = new System.Windows.Forms.ProgressBar();
            this.ProgressBar_Today2 = new System.Windows.Forms.ProgressBar();
            this.Label_WeekIs = new System.Windows.Forms.Label();
            this.Label_WeekValue = new System.Windows.Forms.Label();
            this.ProgressBar_Week1 = new System.Windows.Forms.ProgressBar();
            this.ProgressBar_Week2 = new System.Windows.Forms.ProgressBar();
            this.ProgressBar_Week3 = new System.Windows.Forms.ProgressBar();
            this.ProgressBar_Week4 = new System.Windows.Forms.ProgressBar();
            this.ProgressBar_Week5 = new System.Windows.Forms.ProgressBar();
            this.Button_CopyToday = new System.Windows.Forms.Button();
            this.Button_CopyWeek = new System.Windows.Forms.Button();
            this.Button_Config = new System.Windows.Forms.Button();
            this.Timer_Realtime = new System.Windows.Forms.Timer(this.components);
            this.PictureBox_Mood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Mood)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_NowIs
            // 
            this.Label_NowIs.AutoSize = true;
            this.Label_NowIs.Location = new System.Drawing.Point(12, 9);
            this.Label_NowIs.Name = "Label_NowIs";
            this.Label_NowIs.Size = new System.Drawing.Size(61, 23);
            this.Label_NowIs.TabIndex = 0;
            this.Label_NowIs.Text = "现在是";
            // 
            // Label_Realtime
            // 
            this.Label_Realtime.AutoSize = true;
            this.Label_Realtime.Font = new System.Drawing.Font("Fira Code", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Realtime.Location = new System.Drawing.Point(12, 32);
            this.Label_Realtime.Name = "Label_Realtime";
            this.Label_Realtime.Size = new System.Drawing.Size(338, 33);
            this.Label_Realtime.TabIndex = 0;
            this.Label_Realtime.Text = "yyyy-MM-dd HH:mm:ss";
            // 
            // Label_Weekday
            // 
            this.Label_Weekday.AutoSize = true;
            this.Label_Weekday.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Weekday.Location = new System.Drawing.Point(254, 65);
            this.Label_Weekday.Name = "Label_Weekday";
            this.Label_Weekday.Size = new System.Drawing.Size(96, 36);
            this.Label_Weekday.TabIndex = 0;
            this.Label_Weekday.Text = "星期几";
            // 
            // Label_NydIs
            // 
            this.Label_NydIs.AutoSize = true;
            this.Label_NydIs.Location = new System.Drawing.Point(12, 65);
            this.Label_NydIs.Name = "Label_NydIs";
            this.Label_NydIs.Size = new System.Drawing.Size(112, 23);
            this.Label_NydIs.TabIndex = 0;
            this.Label_NydIs.Text = "奈狄这个时候";
            // 
            // Label_Status
            // 
            this.Label_Status.AutoSize = true;
            this.Label_Status.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Status.Location = new System.Drawing.Point(12, 88);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(123, 36);
            this.Label_Status.TabIndex = 0;
            this.Label_Status.Text = "在干什么";
            // 
            // Label_TodayIs
            // 
            this.Label_TodayIs.AutoSize = true;
            this.Label_TodayIs.Location = new System.Drawing.Point(12, 124);
            this.Label_TodayIs.Name = "Label_TodayIs";
            this.Label_TodayIs.Size = new System.Drawing.Size(112, 23);
            this.Label_TodayIs.TabIndex = 0;
            this.Label_TodayIs.Text = "今日的进度是";
            // 
            // Label_TodayValue
            // 
            this.Label_TodayValue.AutoSize = true;
            this.Label_TodayValue.Font = new System.Drawing.Font("Fira Code", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_TodayValue.Location = new System.Drawing.Point(12, 147);
            this.Label_TodayValue.Name = "Label_TodayValue";
            this.Label_TodayValue.Size = new System.Drawing.Size(236, 33);
            this.Label_TodayValue.TabIndex = 0;
            this.Label_TodayValue.Text = "-------  /  -";
            // 
            // ProgressBar_Today1
            // 
            this.ProgressBar_Today1.Location = new System.Drawing.Point(12, 183);
            this.ProgressBar_Today1.Maximum = 13800;
            this.ProgressBar_Today1.Name = "ProgressBar_Today1";
            this.ProgressBar_Today1.Size = new System.Drawing.Size(166, 15);
            this.ProgressBar_Today1.TabIndex = 1;
            // 
            // ProgressBar_Today2
            // 
            this.ProgressBar_Today2.Location = new System.Drawing.Point(184, 183);
            this.ProgressBar_Today2.Maximum = 14400;
            this.ProgressBar_Today2.Name = "ProgressBar_Today2";
            this.ProgressBar_Today2.Size = new System.Drawing.Size(166, 15);
            this.ProgressBar_Today2.TabIndex = 1;
            // 
            // Label_WeekIs
            // 
            this.Label_WeekIs.AutoSize = true;
            this.Label_WeekIs.Location = new System.Drawing.Point(12, 201);
            this.Label_WeekIs.Name = "Label_WeekIs";
            this.Label_WeekIs.Size = new System.Drawing.Size(112, 23);
            this.Label_WeekIs.TabIndex = 0;
            this.Label_WeekIs.Text = "本周的进度是";
            // 
            // Label_WeekValue
            // 
            this.Label_WeekValue.AutoSize = true;
            this.Label_WeekValue.Font = new System.Drawing.Font("Fira Code", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_WeekValue.Location = new System.Drawing.Point(12, 224);
            this.Label_WeekValue.Name = "Label_WeekValue";
            this.Label_WeekValue.Size = new System.Drawing.Size(236, 33);
            this.Label_WeekValue.TabIndex = 0;
            this.Label_WeekValue.Text = "-------  /  -";
            // 
            // ProgressBar_Week1
            // 
            this.ProgressBar_Week1.Location = new System.Drawing.Point(12, 260);
            this.ProgressBar_Week1.Maximum = 662400;
            this.ProgressBar_Week1.Name = "ProgressBar_Week1";
            this.ProgressBar_Week1.Size = new System.Drawing.Size(63, 15);
            this.ProgressBar_Week1.TabIndex = 1;
            // 
            // ProgressBar_Week2
            // 
            this.ProgressBar_Week2.Location = new System.Drawing.Point(81, 260);
            this.ProgressBar_Week2.Maximum = 662400;
            this.ProgressBar_Week2.Name = "ProgressBar_Week2";
            this.ProgressBar_Week2.Size = new System.Drawing.Size(63, 15);
            this.ProgressBar_Week2.TabIndex = 1;
            // 
            // ProgressBar_Week3
            // 
            this.ProgressBar_Week3.Location = new System.Drawing.Point(150, 260);
            this.ProgressBar_Week3.Maximum = 662400;
            this.ProgressBar_Week3.Name = "ProgressBar_Week3";
            this.ProgressBar_Week3.Size = new System.Drawing.Size(62, 15);
            this.ProgressBar_Week3.TabIndex = 1;
            // 
            // ProgressBar_Week4
            // 
            this.ProgressBar_Week4.Location = new System.Drawing.Point(218, 260);
            this.ProgressBar_Week4.Maximum = 662400;
            this.ProgressBar_Week4.Name = "ProgressBar_Week4";
            this.ProgressBar_Week4.Size = new System.Drawing.Size(63, 15);
            this.ProgressBar_Week4.TabIndex = 1;
            // 
            // ProgressBar_Week5
            // 
            this.ProgressBar_Week5.Location = new System.Drawing.Point(287, 260);
            this.ProgressBar_Week5.Maximum = 662400;
            this.ProgressBar_Week5.Name = "ProgressBar_Week5";
            this.ProgressBar_Week5.Size = new System.Drawing.Size(63, 15);
            this.ProgressBar_Week5.TabIndex = 1;
            // 
            // Button_CopyToday
            // 
            this.Button_CopyToday.Location = new System.Drawing.Point(12, 281);
            this.Button_CopyToday.Name = "Button_CopyToday";
            this.Button_CopyToday.Size = new System.Drawing.Size(132, 40);
            this.Button_CopyToday.TabIndex = 2;
            this.Button_CopyToday.Text = "复制今日进度";
            this.Button_CopyToday.UseVisualStyleBackColor = true;
            this.Button_CopyToday.Click += new System.EventHandler(this.Button_CopyToday_Click);
            // 
            // Button_CopyWeek
            // 
            this.Button_CopyWeek.Location = new System.Drawing.Point(149, 281);
            this.Button_CopyWeek.Name = "Button_CopyWeek";
            this.Button_CopyWeek.Size = new System.Drawing.Size(132, 40);
            this.Button_CopyWeek.TabIndex = 2;
            this.Button_CopyWeek.Text = "复制本周进度";
            this.Button_CopyWeek.UseVisualStyleBackColor = true;
            this.Button_CopyWeek.Click += new System.EventHandler(this.Button_CopyWeek_Click);
            // 
            // Button_Config
            // 
            this.Button_Config.Location = new System.Drawing.Point(287, 281);
            this.Button_Config.Name = "Button_Config";
            this.Button_Config.Size = new System.Drawing.Size(63, 40);
            this.Button_Config.TabIndex = 2;
            this.Button_Config.Text = "设置";
            this.Button_Config.UseVisualStyleBackColor = true;
            this.Button_Config.Click += new System.EventHandler(this.Button_Config_Click);
            // 
            // PictureBox_Mood
            // 
            this.PictureBox_Mood.Image = global::奈狄这周上了多少班_.Res.nyd4;
            this.PictureBox_Mood.Location = new System.Drawing.Point(149, 68);
            this.PictureBox_Mood.Name = "PictureBox_Mood";
            this.PictureBox_Mood.Size = new System.Drawing.Size(64, 64);
            this.PictureBox_Mood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Mood.TabIndex = 3;
            this.PictureBox_Mood.TabStop = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 333);
            this.Controls.Add(this.PictureBox_Mood);
            this.Controls.Add(this.Button_Config);
            this.Controls.Add(this.Button_CopyWeek);
            this.Controls.Add(this.Button_CopyToday);
            this.Controls.Add(this.ProgressBar_Today2);
            this.Controls.Add(this.ProgressBar_Week5);
            this.Controls.Add(this.ProgressBar_Week4);
            this.Controls.Add(this.ProgressBar_Week3);
            this.Controls.Add(this.ProgressBar_Week2);
            this.Controls.Add(this.ProgressBar_Week1);
            this.Controls.Add(this.ProgressBar_Today1);
            this.Controls.Add(this.Label_Status);
            this.Controls.Add(this.Label_Weekday);
            this.Controls.Add(this.Label_WeekValue);
            this.Controls.Add(this.Label_TodayValue);
            this.Controls.Add(this.Label_Realtime);
            this.Controls.Add(this.Label_WeekIs);
            this.Controls.Add(this.Label_TodayIs);
            this.Controls.Add(this.Label_NydIs);
            this.Controls.Add(this.Label_NowIs);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form_Main";
            this.Text = "是什么";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Mood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Label_NowIs;
        private Label Label_Realtime;
        private Label Label_Weekday;
        private Label Label_NydIs;
        private Label Label_Status;
        private Label Label_TodayIs;
        private Label Label_TodayValue;
        private ProgressBar ProgressBar_Today1;
        private ProgressBar ProgressBar_Today2;
        private Label Label_WeekIs;
        private Label Label_WeekValue;
        private ProgressBar ProgressBar_Week1;
        private ProgressBar ProgressBar_Week2;
        private ProgressBar ProgressBar_Week3;
        private ProgressBar ProgressBar_Week4;
        private ProgressBar ProgressBar_Week5;
        private Button Button_CopyToday;
        private Button Button_CopyWeek;
        private Button Button_Config;
        private System.Windows.Forms.Timer Timer_Realtime;
        private PictureBox PictureBox_Mood;
    }
}