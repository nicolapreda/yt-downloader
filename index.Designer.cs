namespace Syncro_Tube
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.syncroTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aiutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoenixpixelitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.SongDownload = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.informazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link video:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.syncroTubeToolStripMenuItem,
            this.preferenzeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // syncroTubeToolStripMenuItem
            // 
            this.syncroTubeToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.syncroTubeToolStripMenuItem.Name = "syncroTubeToolStripMenuItem";
            this.syncroTubeToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.syncroTubeToolStripMenuItem.Text = "Youtube-Downloader";
            // 
            // preferenzeToolStripMenuItem
            // 
            this.preferenzeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aiutoToolStripMenuItem,
            this.phoenixpixelitToolStripMenuItem,
            this.informazioniToolStripMenuItem});
            this.preferenzeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.preferenzeToolStripMenuItem.Name = "preferenzeToolStripMenuItem";
            this.preferenzeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.preferenzeToolStripMenuItem.Text = "Preferenze";
            // 
            // aiutoToolStripMenuItem
            // 
            this.aiutoToolStripMenuItem.Name = "aiutoToolStripMenuItem";
            this.aiutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aiutoToolStripMenuItem.Text = "Aiuto";
            this.aiutoToolStripMenuItem.Click += new System.EventHandler(this.aiutoToolStripMenuItem_Click);
            // 
            // phoenixpixelitToolStripMenuItem
            // 
            this.phoenixpixelitToolStripMenuItem.Name = "phoenixpixelitToolStripMenuItem";
            this.phoenixpixelitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phoenixpixelitToolStripMenuItem.Text = "phoenixpixel.it";
            this.phoenixpixelitToolStripMenuItem.Click += new System.EventHandler(this.phoenixpixelitToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(117, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(529, 39);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = " Download ";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // SongDownload
            // 
            this.SongDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SongDownload.AutoSize = true;
            this.SongDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.SongDownload.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongDownload.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SongDownload.Location = new System.Drawing.Point(12, 123);
            this.SongDownload.Name = "SongDownload";
            this.SongDownload.Size = new System.Drawing.Size(70, 19);
            this.SongDownload.TabIndex = 6;
            this.SongDownload.Text = "song.mp3";
            this.SongDownload.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(605, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(581, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 23);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(446, 123);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(170, 19);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Download video in corso...";
            this.lblInfo.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(16, 81);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "MP3";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(69, 81);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "MP4";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // informazioniToolStripMenuItem
            // 
            this.informazioniToolStripMenuItem.Name = "informazioniToolStripMenuItem";
            this.informazioniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informazioniToolStripMenuItem.Text = "Informazioni";
            this.informazioniToolStripMenuItem.Click += new System.EventHandler(this.informazioniToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(628, 151);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.SongDownload);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Syncro-tube";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem syncroTubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferenzeToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label SongDownload;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.ToolStripMenuItem aiutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoenixpixelitToolStripMenuItem;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ToolStripMenuItem informazioniToolStripMenuItem;
    }
}

