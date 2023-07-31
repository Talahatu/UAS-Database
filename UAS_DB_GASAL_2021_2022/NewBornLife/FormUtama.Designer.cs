namespace NewbornLife
{
    partial class FormUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataBayiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktivitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minumSusuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNama = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBayiToolStripMenuItem,
            this.aktivitasToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataBayiToolStripMenuItem
            // 
            this.dataBayiToolStripMenuItem.Name = "dataBayiToolStripMenuItem";
            this.dataBayiToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.dataBayiToolStripMenuItem.Text = "&Data Bayi";
            this.dataBayiToolStripMenuItem.Click += new System.EventHandler(this.dataBayiToolStripMenuItem_Click);
            // 
            // aktivitasToolStripMenuItem
            // 
            this.aktivitasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minumSusuToolStripMenuItem});
            this.aktivitasToolStripMenuItem.Name = "aktivitasToolStripMenuItem";
            this.aktivitasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.aktivitasToolStripMenuItem.Text = "&Aktivitas";
            // 
            // minumSusuToolStripMenuItem
            // 
            this.minumSusuToolStripMenuItem.Name = "minumSusuToolStripMenuItem";
            this.minumSusuToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.minumSusuToolStripMenuItem.Text = "Minum &Susu";
            this.minumSusuToolStripMenuItem.Click += new System.EventHandler(this.minumSusuToolStripMenuItem_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.keluarToolStripMenuItem.Text = "&Keluar";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(726, 6);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(100, 13);
            this.labelNama.TabIndex = 2;
            this.labelNama.Text = "Nama Pengguna";
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUtama";
            this.Text = "Newborn Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataBayiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktivitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minumSusuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.Label labelNama;
    }
}

