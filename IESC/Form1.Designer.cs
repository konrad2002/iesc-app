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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.website = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_web_refresh = new System.Windows.Forms.Button();
            this.btn_web_back = new System.Windows.Forms.Button();
            this.btn_open_website = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabFiles = new System.Windows.Forms.TabPage();
            this.tabStream = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.content.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.82884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.17116F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.content, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.72046F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 904F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1262, 931);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.website, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(857, 29);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.88889F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.111111F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(403, 900);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // website
            // 
            this.website.Dock = System.Windows.Forms.DockStyle.Fill;
            this.website.Location = new System.Drawing.Point(2, 2);
            this.website.Margin = new System.Windows.Forms.Padding(2);
            this.website.MinimumSize = new System.Drawing.Size(15, 16);
            this.website.Name = "website";
            this.website.ScriptErrorsSuppressed = true;
            this.website.Size = new System.Drawing.Size(399, 840);
            this.website.TabIndex = 0;
            this.website.Url = new System.Uri("http://www.erzgebirgsschwimmcup.de/index.php/dateien-links#content", System.UriKind.Absolute);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.23077F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.76923F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.Controls.Add(this.btn_web_refresh, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_web_back, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_open_website, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 846);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(399, 52);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btn_web_refresh
            // 
            this.btn_web_refresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_web_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_web_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_web_refresh.Location = new System.Drawing.Point(124, 2);
            this.btn_web_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_web_refresh.Name = "btn_web_refresh";
            this.btn_web_refresh.Size = new System.Drawing.Size(122, 48);
            this.btn_web_refresh.TabIndex = 0;
            this.btn_web_refresh.Text = "Neu laden";
            this.btn_web_refresh.Click += new System.EventHandler(this.btn_web_refresh_Click);
            // 
            // btn_web_back
            // 
            this.btn_web_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_web_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_web_back.ForeColor = System.Drawing.Color.White;
            this.btn_web_back.Location = new System.Drawing.Point(2, 2);
            this.btn_web_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_web_back.Name = "btn_web_back";
            this.btn_web_back.Size = new System.Drawing.Size(118, 48);
            this.btn_web_back.TabIndex = 0;
            this.btn_web_back.Text = "Zurück";
            this.btn_web_back.UseVisualStyleBackColor = true;
            this.btn_web_back.Click += new System.EventHandler(this.btn_web_back_Click);
            // 
            // btn_open_website
            // 
            this.btn_open_website.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_open_website.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open_website.ForeColor = System.Drawing.Color.White;
            this.btn_open_website.Location = new System.Drawing.Point(250, 2);
            this.btn_open_website.Margin = new System.Windows.Forms.Padding(2);
            this.btn_open_website.Name = "btn_open_website";
            this.btn_open_website.Size = new System.Drawing.Size(147, 48);
            this.btn_open_website.TabIndex = 0;
            this.btn_open_website.Text = "Website im Browser öffnen";
            this.btn_open_website.UseVisualStyleBackColor = true;
            this.btn_open_website.Click += new System.EventHandler(this.btn_open_website_Click);
            // 
            // content
            // 
            this.content.Controls.Add(this.tabMain);
            this.content.Controls.Add(this.tabFiles);
            this.content.Controls.Add(this.tabStream);
            this.content.Location = new System.Drawing.Point(3, 30);
            this.content.Name = "content";
            this.content.SelectedIndex = 0;
            this.content.Size = new System.Drawing.Size(849, 898);
            this.content.TabIndex = 3;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.tabMain.Controls.Add(this.trackBar1);
            this.tabMain.Controls.Add(this.progressBar1);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(841, 872);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Start";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(38, 243);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(738, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 193);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(738, 23);
            this.progressBar1.Step = 100;
            this.progressBar1.TabIndex = 0;
            // 
            // tabFiles
            // 
            this.tabFiles.Location = new System.Drawing.Point(4, 22);
            this.tabFiles.Name = "tabFiles";
            this.tabFiles.Size = new System.Drawing.Size(841, 872);
            this.tabFiles.TabIndex = 2;
            this.tabFiles.Text = "Dateien";
            this.tabFiles.UseVisualStyleBackColor = true;
            // 
            // tabStream
            // 
            this.tabStream.Location = new System.Drawing.Point(4, 22);
            this.tabStream.Name = "tabStream";
            this.tabStream.Padding = new System.Windows.Forms.Padding(3);
            this.tabStream.Size = new System.Drawing.Size(841, 872);
            this.tabStream.TabIndex = 1;
            this.tabStream.Text = "Stream";
            this.tabStream.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 931);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "IESC";
            this.Load += new System.EventHandler(this.main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.content.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_web_back;
        private System.Windows.Forms.Button btn_open_website;
        private System.Windows.Forms.Button btn_web_refresh;
        private System.Windows.Forms.WebBrowser website;
        private System.Windows.Forms.TabControl content;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage tabFiles;
        private System.Windows.Forms.TabPage tabStream;
    }
}

