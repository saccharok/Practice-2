
namespace WindowsFormsApp1
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelKn = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.ControlButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.timerToDraw = new System.Windows.Forms.Timer(this.components);
            this.trackBarKnight = new System.Windows.Forms.TrackBar();
            this.knightTextBox = new System.Windows.Forms.TextBox();
            this.trackBarHospital = new System.Windows.Forms.TrackBar();
            this.castleTextBox = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.labelOver = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelKnOv = new System.Windows.Forms.Label();
            this.labelCasOver = new System.Windows.Forms.Label();
            this.labelHospOv = new System.Windows.Forms.Label();
            this.labelTimeOv = new System.Windows.Forms.Label();
            this.timeOv = new System.Windows.Forms.Label();
            this.hospOv = new System.Windows.Forms.Label();
            this.casOv = new System.Windows.Forms.Label();
            this.knOv = new System.Windows.Forms.Label();
            this.labelTalk = new System.Windows.Forms.Label();
            this.talkOv = new System.Windows.Forms.Label();
            this.labelEndBef = new System.Windows.Forms.Label();
            this.trackBarVis = new System.Windows.Forms.TrackBar();
            this.textBoxVis = new System.Windows.Forms.TextBox();
            this.labelVis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVis)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tag = "";
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelKn
            // 
            this.labelKn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKn.AutoSize = true;
            this.labelKn.Location = new System.Drawing.Point(332, 133);
            this.labelKn.Name = "labelKn";
            this.labelKn.Size = new System.Drawing.Size(148, 17);
            this.labelKn.TabIndex = 17;
            this.labelKn.Text = "Количество рыцарей";
            this.labelKn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTimer
            // 
            this.labelTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(1316, 25);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(186, 17);
            this.labelTimer.TabIndex = 15;
            this.labelTimer.Text = "Время работы сиумляции: ";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(1508, 25);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(16, 17);
            this.timerLabel.TabIndex = 14;
            this.timerLabel.Text = "0";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Help;
            this.helpButton.ForeColor = System.Drawing.SystemColors.Control;
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.helpButton.Location = new System.Drawing.Point(12, 60);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(351, 42);
            this.helpButton.TabIndex = 13;
            this.helpButton.Text = "Помощь";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // ControlButton
            // 
            this.ControlButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.ControlButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ControlButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ControlButton.Location = new System.Drawing.Point(12, 12);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(351, 42);
            this.ControlButton.TabIndex = 12;
            this.ControlButton.Text = "Запуск";
            this.ControlButton.UseVisualStyleBackColor = false;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StopButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.StopButton.ForeColor = System.Drawing.SystemColors.Control;
            this.StopButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StopButton.Location = new System.Drawing.Point(369, 12);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(816, 42);
            this.StopButton.TabIndex = 19;
            this.StopButton.Text = "Остановка симуляции";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(267, 310);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 89);
            this.checkedListBox1.TabIndex = 0;
            // 
            // timerToDraw
            // 
            this.timerToDraw.Interval = 5;
            this.timerToDraw.Tick += new System.EventHandler(this.timerToDraw_Tick);
            // 
            // trackBarKnight
            // 
            this.trackBarKnight.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trackBarKnight.LargeChange = 1;
            this.trackBarKnight.Location = new System.Drawing.Point(12, 130);
            this.trackBarKnight.Maximum = 500;
            this.trackBarKnight.Minimum = 100;
            this.trackBarKnight.Name = "trackBarKnight";
            this.trackBarKnight.Size = new System.Drawing.Size(259, 56);
            this.trackBarKnight.TabIndex = 20;
            this.trackBarKnight.TickFrequency = 50;
            this.trackBarKnight.Value = 100;
            this.trackBarKnight.Scroll += new System.EventHandler(this.trackBarKnight_Scroll);
            // 
            // knightTextBox
            // 
            this.knightTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.knightTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knightTextBox.Location = new System.Drawing.Point(277, 130);
            this.knightTextBox.Name = "knightTextBox";
            this.knightTextBox.Size = new System.Drawing.Size(49, 22);
            this.knightTextBox.TabIndex = 16;
            this.knightTextBox.Text = "Число";
            this.knightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trackBarHospital
            // 
            this.trackBarHospital.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trackBarHospital.LargeChange = 1;
            this.trackBarHospital.Location = new System.Drawing.Point(12, 192);
            this.trackBarHospital.Maximum = 5;
            this.trackBarHospital.Minimum = 1;
            this.trackBarHospital.Name = "trackBarHospital";
            this.trackBarHospital.Size = new System.Drawing.Size(259, 56);
            this.trackBarHospital.TabIndex = 21;
            this.trackBarHospital.Value = 3;
            this.trackBarHospital.Scroll += new System.EventHandler(this.trackBarHospital_Scroll);
            // 
            // castleTextBox
            // 
            this.castleTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.castleTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.castleTextBox.Location = new System.Drawing.Point(277, 192);
            this.castleTextBox.Name = "castleTextBox";
            this.castleTextBox.Size = new System.Drawing.Size(49, 22);
            this.castleTextBox.TabIndex = 22;
            this.castleTextBox.Text = "Число";
            this.castleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelC
            // 
            this.labelC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(332, 195);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(154, 17);
            this.labelC.TabIndex = 23;
            this.labelC.Text = "Количество лечебниц";
            this.labelC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOver
            // 
            this.labelOver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOver.AutoSize = true;
            this.labelOver.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelOver.Location = new System.Drawing.Point(945, 25);
            this.labelOver.Name = "labelOver";
            this.labelOver.Size = new System.Drawing.Size(210, 26);
            this.labelOver.TabIndex = 24;
            this.labelOver.Text = "ИТОГИ СИМУЛЯЦИИ";
            // 
            // labelAuthor
            // 
            this.labelAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(1382, 583);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(156, 17);
            this.labelAuthor.TabIndex = 25;
            this.labelAuthor.Text = "Земская Софья ПИ-02";
            this.labelAuthor.Visible = false;
            // 
            // labelKnOv
            // 
            this.labelKnOv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKnOv.AutoSize = true;
            this.labelKnOv.Location = new System.Drawing.Point(547, 135);
            this.labelKnOv.Name = "labelKnOv";
            this.labelKnOv.Size = new System.Drawing.Size(148, 17);
            this.labelKnOv.TabIndex = 26;
            this.labelKnOv.Text = "Количество рыцарей";
            this.labelKnOv.Visible = false;
            // 
            // labelCasOver
            // 
            this.labelCasOver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCasOver.AutoSize = true;
            this.labelCasOver.Location = new System.Drawing.Point(460, 197);
            this.labelCasOver.Name = "labelCasOver";
            this.labelCasOver.Size = new System.Drawing.Size(235, 17);
            this.labelCasOver.TabIndex = 27;
            this.labelCasOver.Text = "Количество уничтоженных замков";
            this.labelCasOver.Visible = false;
            // 
            // labelHospOv
            // 
            this.labelHospOv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHospOv.AutoSize = true;
            this.labelHospOv.Location = new System.Drawing.Point(461, 257);
            this.labelHospOv.Name = "labelHospOv";
            this.labelHospOv.Size = new System.Drawing.Size(234, 17);
            this.labelHospOv.TabIndex = 29;
            this.labelHospOv.Text = "Количество лечений в госпиталях";
            this.labelHospOv.Visible = false;
            // 
            // labelTimeOv
            // 
            this.labelTimeOv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimeOv.AutoSize = true;
            this.labelTimeOv.Location = new System.Drawing.Point(433, 319);
            this.labelTimeOv.Name = "labelTimeOv";
            this.labelTimeOv.Size = new System.Drawing.Size(262, 17);
            this.labelTimeOv.TabIndex = 31;
            this.labelTimeOv.Text = "Время работы симуляции( в секундах)";
            this.labelTimeOv.Visible = false;
            // 
            // timeOv
            // 
            this.timeOv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeOv.AutoSize = true;
            this.timeOv.Location = new System.Drawing.Point(1291, 319);
            this.timeOv.Name = "timeOv";
            this.timeOv.Size = new System.Drawing.Size(16, 17);
            this.timeOv.TabIndex = 35;
            this.timeOv.Text = "0";
            this.timeOv.Visible = false;
            // 
            // hospOv
            // 
            this.hospOv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hospOv.AutoSize = true;
            this.hospOv.Location = new System.Drawing.Point(1291, 257);
            this.hospOv.Name = "hospOv";
            this.hospOv.Size = new System.Drawing.Size(16, 17);
            this.hospOv.TabIndex = 34;
            this.hospOv.Text = "0";
            this.hospOv.Visible = false;
            // 
            // casOv
            // 
            this.casOv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.casOv.AutoSize = true;
            this.casOv.Location = new System.Drawing.Point(1291, 195);
            this.casOv.Name = "casOv";
            this.casOv.Size = new System.Drawing.Size(16, 17);
            this.casOv.TabIndex = 33;
            this.casOv.Text = "0";
            this.casOv.Visible = false;
            // 
            // knOv
            // 
            this.knOv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.knOv.AutoSize = true;
            this.knOv.Location = new System.Drawing.Point(1291, 135);
            this.knOv.Name = "knOv";
            this.knOv.Size = new System.Drawing.Size(16, 17);
            this.knOv.TabIndex = 32;
            this.knOv.Text = "0";
            this.knOv.Visible = false;
            // 
            // labelTalk
            // 
            this.labelTalk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTalk.AutoSize = true;
            this.labelTalk.Location = new System.Drawing.Point(484, 383);
            this.labelTalk.Name = "labelTalk";
            this.labelTalk.Size = new System.Drawing.Size(211, 17);
            this.labelTalk.TabIndex = 36;
            this.labelTalk.Text = "Количество общений рыцарей\r\n";
            this.labelTalk.Visible = false;
            // 
            // talkOv
            // 
            this.talkOv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.talkOv.AutoSize = true;
            this.talkOv.Location = new System.Drawing.Point(1291, 383);
            this.talkOv.Name = "talkOv";
            this.talkOv.Size = new System.Drawing.Size(16, 17);
            this.talkOv.TabIndex = 37;
            this.talkOv.Text = "0";
            this.talkOv.Visible = false;
            // 
            // labelEndBef
            // 
            this.labelEndBef.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEndBef.AutoSize = true;
            this.labelEndBef.Location = new System.Drawing.Point(616, 57);
            this.labelEndBef.Name = "labelEndBef";
            this.labelEndBef.Size = new System.Drawing.Size(378, 17);
            this.labelEndBef.TabIndex = 38;
            this.labelEndBef.Text = "СИМУЛЯЦИЯ ЗАВЕРШЕНА ЕСТЕСТВЕННЫМ ОБРАЗОМ\r\n";
            this.labelEndBef.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelEndBef.Visible = false;
            // 
            // trackBarVis
            // 
            this.trackBarVis.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trackBarVis.LargeChange = 50;
            this.trackBarVis.Location = new System.Drawing.Point(12, 254);
            this.trackBarVis.Maximum = 250;
            this.trackBarVis.Minimum = 50;
            this.trackBarVis.Name = "trackBarVis";
            this.trackBarVis.Size = new System.Drawing.Size(259, 56);
            this.trackBarVis.SmallChange = 50;
            this.trackBarVis.TabIndex = 39;
            this.trackBarVis.TickFrequency = 50;
            this.trackBarVis.Value = 50;
            this.trackBarVis.Scroll += new System.EventHandler(this.trackBarVis_Scroll);
            // 
            // textBoxVis
            // 
            this.textBoxVis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxVis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxVis.Location = new System.Drawing.Point(277, 252);
            this.textBoxVis.Name = "textBoxVis";
            this.textBoxVis.Size = new System.Drawing.Size(49, 22);
            this.textBoxVis.TabIndex = 40;
            this.textBoxVis.Text = "Число";
            this.textBoxVis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelVis
            // 
            this.labelVis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVis.AutoSize = true;
            this.labelVis.Location = new System.Drawing.Point(332, 254);
            this.labelVis.Name = "labelVis";
            this.labelVis.Size = new System.Drawing.Size(183, 17);
            this.labelVis.TabIndex = 41;
            this.labelVis.Text = "Радиус видимости рыцаря";
            this.labelVis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1550, 673);
            this.Controls.Add(this.labelVis);
            this.Controls.Add(this.textBoxVis);
            this.Controls.Add(this.trackBarVis);
            this.Controls.Add(this.labelEndBef);
            this.Controls.Add(this.talkOv);
            this.Controls.Add(this.labelTalk);
            this.Controls.Add(this.timeOv);
            this.Controls.Add(this.hospOv);
            this.Controls.Add(this.casOv);
            this.Controls.Add(this.knOv);
            this.Controls.Add(this.labelTimeOv);
            this.Controls.Add(this.labelHospOv);
            this.Controls.Add(this.labelCasOver);
            this.Controls.Add(this.labelKnOv);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.castleTextBox);
            this.Controls.Add(this.trackBarHospital);
            this.Controls.Add(this.trackBarKnight);
            this.Controls.Add(this.labelKn);
            this.Controls.Add(this.knightTextBox);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.labelOver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Симуляция";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelKn;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Timer timerToDraw;
        private System.Windows.Forms.TrackBar trackBarKnight;
        private System.Windows.Forms.TextBox knightTextBox;
        private System.Windows.Forms.TrackBar trackBarHospital;
        private System.Windows.Forms.TextBox castleTextBox;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelOver;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelKnOv;
        private System.Windows.Forms.Label labelCasOver;
        private System.Windows.Forms.Label labelHospOv;
        private System.Windows.Forms.Label labelTimeOv;
        private System.Windows.Forms.Label timeOv;
        private System.Windows.Forms.Label hospOv;
        private System.Windows.Forms.Label casOv;
        private System.Windows.Forms.Label knOv;
        private System.Windows.Forms.Label labelTalk;
        private System.Windows.Forms.Label talkOv;
        private System.Windows.Forms.Label labelEndBef;
        private System.Windows.Forms.TrackBar trackBarVis;
        private System.Windows.Forms.TextBox textBoxVis;
        private System.Windows.Forms.Label labelVis;
    }
}