namespace IESC
{
    partial class main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.BtnStart = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DistanceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WkBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.Time8 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Time7 = new System.Windows.Forms.Label();
            this.Time6 = new System.Windows.Forms.Label();
            this.Time3 = new System.Windows.Forms.Label();
            this.Time5 = new System.Windows.Forms.Label();
            this.Time2 = new System.Windows.Forms.Label();
            this.Time4 = new System.Windows.Forms.Label();
            this.Time1 = new System.Windows.Forms.Label();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logTime2 = new System.Windows.Forms.ListBox();
            this.logTime = new System.Windows.Forms.ListBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnRequest = new System.Windows.Forms.Button();
            this.BtnLivetiming = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnExecuteStop = new System.Windows.Forms.Button();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.BtnSwitcher = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(13, 17);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(2);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(123, 34);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DistanceBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.WkBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TimeBox);
            this.groupBox1.Controls.Add(this.Time8);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.Time7);
            this.groupBox1.Controls.Add(this.Time6);
            this.groupBox1.Controls.Add(this.Time3);
            this.groupBox1.Controls.Add(this.Time5);
            this.groupBox1.Controls.Add(this.Time2);
            this.groupBox1.Controls.Add(this.Time4);
            this.groupBox1.Controls.Add(this.Time1);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.BtnStop);
            this.groupBox1.Controls.Add(this.clock);
            this.groupBox1.Controls.Add(this.BtnStart);
            this.groupBox1.Location = new System.Drawing.Point(9, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(405, 217);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lauf";
            // 
            // DistanceBox
            // 
            this.DistanceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistanceBox.Location = new System.Drawing.Point(295, 63);
            this.DistanceBox.Margin = new System.Windows.Forms.Padding(2);
            this.DistanceBox.Name = "DistanceBox";
            this.DistanceBox.Size = new System.Drawing.Size(98, 46);
            this.DistanceBox.TabIndex = 15;
            this.DistanceBox.Text = "0m";
            this.DistanceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Strecke:";
            // 
            // WkBox
            // 
            this.WkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WkBox.Location = new System.Drawing.Point(84, 63);
            this.WkBox.Margin = new System.Windows.Forms.Padding(2);
            this.WkBox.Name = "WkBox";
            this.WkBox.Size = new System.Drawing.Size(77, 46);
            this.WkBox.TabIndex = 7;
            this.WkBox.Text = "---";
            this.WkBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "WK:";
            // 
            // TimeBox
            // 
            this.TimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBox.Location = new System.Drawing.Point(13, 116);
            this.TimeBox.Margin = new System.Windows.Forms.Padding(2);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(66, 46);
            this.TimeBox.TabIndex = 13;
            this.TimeBox.Text = "0";
            this.TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Time8
            // 
            this.Time8.AutoSize = true;
            this.Time8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time8.Location = new System.Drawing.Point(341, 142);
            this.Time8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time8.Name = "Time8";
            this.Time8.Size = new System.Drawing.Size(52, 20);
            this.Time8.TabIndex = 12;
            this.Time8.Text = "Time8";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 180);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(385, 24);
            this.progressBar.TabIndex = 4;
            // 
            // Time7
            // 
            this.Time7.AutoSize = true;
            this.Time7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time7.Location = new System.Drawing.Point(287, 142);
            this.Time7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time7.Name = "Time7";
            this.Time7.Size = new System.Drawing.Size(52, 20);
            this.Time7.TabIndex = 11;
            this.Time7.Text = "Time7";
            // 
            // Time6
            // 
            this.Time6.AutoSize = true;
            this.Time6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time6.Location = new System.Drawing.Point(232, 142);
            this.Time6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time6.Name = "Time6";
            this.Time6.Size = new System.Drawing.Size(52, 20);
            this.Time6.TabIndex = 10;
            this.Time6.Text = "Time6";
            // 
            // Time3
            // 
            this.Time3.AutoSize = true;
            this.Time3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time3.Location = new System.Drawing.Point(287, 117);
            this.Time3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time3.Name = "Time3";
            this.Time3.Size = new System.Drawing.Size(52, 20);
            this.Time3.TabIndex = 9;
            this.Time3.Text = "Time3";
            // 
            // Time5
            // 
            this.Time5.AutoSize = true;
            this.Time5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time5.Location = new System.Drawing.Point(177, 142);
            this.Time5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time5.Name = "Time5";
            this.Time5.Size = new System.Drawing.Size(52, 20);
            this.Time5.TabIndex = 8;
            this.Time5.Text = "Time5";
            // 
            // Time2
            // 
            this.Time2.AutoSize = true;
            this.Time2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time2.Location = new System.Drawing.Point(232, 117);
            this.Time2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time2.Name = "Time2";
            this.Time2.Size = new System.Drawing.Size(52, 20);
            this.Time2.TabIndex = 7;
            this.Time2.Text = "Time2";
            // 
            // Time4
            // 
            this.Time4.AutoSize = true;
            this.Time4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time4.Location = new System.Drawing.Point(341, 117);
            this.Time4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time4.Name = "Time4";
            this.Time4.Size = new System.Drawing.Size(52, 20);
            this.Time4.TabIndex = 6;
            this.Time4.Text = "Time4";
            // 
            // Time1
            // 
            this.Time1.AutoSize = true;
            this.Time1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time1.Location = new System.Drawing.Point(177, 117);
            this.Time1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time1.Name = "Time1";
            this.Time1.Size = new System.Drawing.Size(52, 20);
            this.Time1.TabIndex = 5;
            this.Time1.Text = "Time1";
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(270, 17);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(123, 34);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.Text = "Neu";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(142, 17);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(2);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(123, 34);
            this.BtnStop.TabIndex = 3;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // clock
            // 
            this.clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock.Location = new System.Drawing.Point(83, 116);
            this.clock.Margin = new System.Windows.Forms.Padding(2);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(91, 46);
            this.clock.TabIndex = 2;
            this.clock.Text = "00:00";
            this.clock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logTime2);
            this.groupBox2.Controls.Add(this.logTime);
            this.groupBox2.Controls.Add(this.BtnClear);
            this.groupBox2.Controls.Add(this.log);
            this.groupBox2.Location = new System.Drawing.Point(9, 322);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(405, 261);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ereignisse";
            // 
            // logTime2
            // 
            this.logTime2.FormattingEnabled = true;
            this.logTime2.Location = new System.Drawing.Point(69, 69);
            this.logTime2.Margin = new System.Windows.Forms.Padding(2);
            this.logTime2.Name = "logTime2";
            this.logTime2.Size = new System.Drawing.Size(45, 186);
            this.logTime2.TabIndex = 3;
            // 
            // logTime
            // 
            this.logTime.FormattingEnabled = true;
            this.logTime.Location = new System.Drawing.Point(4, 69);
            this.logTime.Margin = new System.Windows.Forms.Padding(2);
            this.logTime.Name = "logTime";
            this.logTime.Size = new System.Drawing.Size(61, 186);
            this.logTime.TabIndex = 2;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(4, 24);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(392, 29);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Liste löschen";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // log
            // 
            this.log.FormattingEnabled = true;
            this.log.Location = new System.Drawing.Point(118, 69);
            this.log.Margin = new System.Windows.Forms.Padding(2);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(279, 186);
            this.log.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnSwitcher);
            this.groupBox3.Controls.Add(this.BtnRequest);
            this.groupBox3.Controls.Add(this.BtnLivetiming);
            this.groupBox3.Location = new System.Drawing.Point(9, 601);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(405, 58);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "weitere Funktionen";
            // 
            // BtnRequest
            // 
            this.BtnRequest.Location = new System.Drawing.Point(270, 22);
            this.BtnRequest.Name = "BtnRequest";
            this.BtnRequest.Size = new System.Drawing.Size(120, 26);
            this.BtnRequest.TabIndex = 5;
            this.BtnRequest.Text = "manuelle Abfrage";
            this.BtnRequest.UseVisualStyleBackColor = true;
            this.BtnRequest.Click += new System.EventHandler(this.BtnRequest_Click);
            // 
            // BtnLivetiming
            // 
            this.BtnLivetiming.Location = new System.Drawing.Point(18, 21);
            this.BtnLivetiming.Name = "BtnLivetiming";
            this.BtnLivetiming.Size = new System.Drawing.Size(120, 26);
            this.BtnLivetiming.TabIndex = 4;
            this.BtnLivetiming.Text = "Livetiming anzeigen";
            this.BtnLivetiming.UseVisualStyleBackColor = true;
            this.BtnLivetiming.Click += new System.EventHandler(this.BtnLivetiming_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.BtnExecuteStop);
            this.groupBox4.Controls.Add(this.BtnExecute);
            this.groupBox4.Location = new System.Drawing.Point(9, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(405, 78);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Programm";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(250, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "gestoppt";
            // 
            // BtnExecuteStop
            // 
            this.BtnExecuteStop.Location = new System.Drawing.Point(135, 24);
            this.BtnExecuteStop.Name = "BtnExecuteStop";
            this.BtnExecuteStop.Size = new System.Drawing.Size(109, 35);
            this.BtnExecuteStop.TabIndex = 1;
            this.BtnExecuteStop.Text = "Anhalten";
            this.BtnExecuteStop.UseVisualStyleBackColor = true;
            this.BtnExecuteStop.Click += new System.EventHandler(this.BtnExecuteStop_Click);
            // 
            // BtnExecute
            // 
            this.BtnExecute.Location = new System.Drawing.Point(20, 24);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(109, 35);
            this.BtnExecute.TabIndex = 0;
            this.BtnExecute.Text = "Starten";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // BtnSwitcher
            // 
            this.BtnSwitcher.Location = new System.Drawing.Point(144, 24);
            this.BtnSwitcher.Name = "BtnSwitcher";
            this.BtnSwitcher.Size = new System.Drawing.Size(120, 23);
            this.BtnSwitcher.TabIndex = 6;
            this.BtnSwitcher.Text = "Szenenwechsler";
            this.BtnSwitcher.UseVisualStyleBackColor = true;
            this.BtnSwitcher.Click += new System.EventHandler(this.BtnSwitcher_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 670);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "IESC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.TextBox clock;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.ListBox log;
        private System.Windows.Forms.ListBox logTime;
        private System.Windows.Forms.Label Time6;
        private System.Windows.Forms.Label Time3;
        private System.Windows.Forms.Label Time5;
        private System.Windows.Forms.Label Time2;
        private System.Windows.Forms.Label Time4;
        private System.Windows.Forms.Label Time1;
        private System.Windows.Forms.Label Time8;
        private System.Windows.Forms.Label Time7;
        private System.Windows.Forms.ListBox logTime2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnLivetiming;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnExecuteStop;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.Button BtnRequest;
        private System.Windows.Forms.TextBox DistanceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Button BtnSwitcher;
    }
}

