namespace PBKK_230908_PenyuntingTeks
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.berkasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suntingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulangiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.potongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pilihSemuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waktuTanggalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "oa";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.berkasToolStripMenuItem,
            this.suntingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // berkasToolStripMenuItem
            // 
            this.berkasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baruToolStripMenuItem,
            this.bukaToolStripMenuItem,
            this.simpanToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.berkasToolStripMenuItem.Name = "berkasToolStripMenuItem";
            this.berkasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.berkasToolStripMenuItem.Text = "Berkas";
            // 
            // baruToolStripMenuItem
            // 
            this.baruToolStripMenuItem.Name = "baruToolStripMenuItem";
            this.baruToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.baruToolStripMenuItem.Text = "Baru";
            this.baruToolStripMenuItem.Click += new System.EventHandler(this.baruToolStripMenuItem_Click);
            // 
            // bukaToolStripMenuItem
            // 
            this.bukaToolStripMenuItem.Name = "bukaToolStripMenuItem";
            this.bukaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bukaToolStripMenuItem.Text = "Buka";
            this.bukaToolStripMenuItem.Click += new System.EventHandler(this.bukaToolStripMenuItem_Click);
            // 
            // simpanToolStripMenuItem
            // 
            this.simpanToolStripMenuItem.Name = "simpanToolStripMenuItem";
            this.simpanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.simpanToolStripMenuItem.Text = "Simpan";
            this.simpanToolStripMenuItem.Click += new System.EventHandler(this.simpanToolStripMenuItem_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // suntingToolStripMenuItem
            // 
            this.suntingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.batalToolStripMenuItem,
            this.ulangiToolStripMenuItem,
            this.toolStripSeparator1,
            this.potongToolStripMenuItem,
            this.salinToolStripMenuItem,
            this.tempelToolStripMenuItem,
            this.toolStripSeparator2,
            this.pilihSemuaToolStripMenuItem,
            this.waktuTanggalToolStripMenuItem});
            this.suntingToolStripMenuItem.Name = "suntingToolStripMenuItem";
            this.suntingToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.suntingToolStripMenuItem.Text = "Sunting";
            // 
            // batalToolStripMenuItem
            // 
            this.batalToolStripMenuItem.Name = "batalToolStripMenuItem";
            this.batalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.batalToolStripMenuItem.Text = "Batal (undo)";
            this.batalToolStripMenuItem.Click += new System.EventHandler(this.batalToolStripMenuItem_Click);
            // 
            // ulangiToolStripMenuItem
            // 
            this.ulangiToolStripMenuItem.Name = "ulangiToolStripMenuItem";
            this.ulangiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ulangiToolStripMenuItem.Text = "Ulangi (redo)";
            this.ulangiToolStripMenuItem.Click += new System.EventHandler(this.ulangiToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // potongToolStripMenuItem
            // 
            this.potongToolStripMenuItem.Name = "potongToolStripMenuItem";
            this.potongToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.potongToolStripMenuItem.Text = "Potong";
            this.potongToolStripMenuItem.Click += new System.EventHandler(this.potongToolStripMenuItem_Click);
            // 
            // salinToolStripMenuItem
            // 
            this.salinToolStripMenuItem.Name = "salinToolStripMenuItem";
            this.salinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salinToolStripMenuItem.Text = "Salin";
            this.salinToolStripMenuItem.Click += new System.EventHandler(this.salinToolStripMenuItem_Click);
            // 
            // tempelToolStripMenuItem
            // 
            this.tempelToolStripMenuItem.Name = "tempelToolStripMenuItem";
            this.tempelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tempelToolStripMenuItem.Text = "Tempel";
            this.tempelToolStripMenuItem.Click += new System.EventHandler(this.tempelToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // pilihSemuaToolStripMenuItem
            // 
            this.pilihSemuaToolStripMenuItem.Name = "pilihSemuaToolStripMenuItem";
            this.pilihSemuaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pilihSemuaToolStripMenuItem.Text = "Pilih Semua";
            this.pilihSemuaToolStripMenuItem.Click += new System.EventHandler(this.pilihSemuaToolStripMenuItem_Click);
            // 
            // waktuTanggalToolStripMenuItem
            // 
            this.waktuTanggalToolStripMenuItem.Name = "waktuTanggalToolStripMenuItem";
            this.waktuTanggalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.waktuTanggalToolStripMenuItem.Text = "Waktu/Tanggal";
            this.waktuTanggalToolStripMenuItem.Click += new System.EventHandler(this.waktuTanggalToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem berkasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suntingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ulangiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilihSemuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waktuTanggalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

