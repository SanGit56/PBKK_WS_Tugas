namespace PBKK_230915_MediaCapture
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxWebcam = new ComboBox();
            mulaiTmbl = new Button();
            rekamTmbl = new Button();
            simpanTmbl = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWebcam
            // 
            comboBoxWebcam.FormattingEnabled = true;
            comboBoxWebcam.Location = new Point(12, 15);
            comboBoxWebcam.Name = "comboBoxWebcam";
            comboBoxWebcam.Size = new Size(155, 23);
            comboBoxWebcam.TabIndex = 0;
            comboBoxWebcam.SelectedIndexChanged += comboBoxWebcam_SelectedIndexChanged;
            // 
            // mulaiTmbl
            // 
            mulaiTmbl.Location = new Point(42, 216);
            mulaiTmbl.Name = "mulaiTmbl";
            mulaiTmbl.Size = new Size(99, 38);
            mulaiTmbl.TabIndex = 1;
            mulaiTmbl.Text = "Mulai";
            mulaiTmbl.UseVisualStyleBackColor = true;
            mulaiTmbl.Click += button1_Click;
            // 
            // rekamTmbl
            // 
            rekamTmbl.Location = new Point(42, 281);
            rekamTmbl.Name = "rekamTmbl";
            rekamTmbl.Size = new Size(99, 38);
            rekamTmbl.TabIndex = 2;
            rekamTmbl.Text = "Rekam";
            rekamTmbl.UseVisualStyleBackColor = true;
            rekamTmbl.Click += button2_Click;
            // 
            // simpanTmbl
            // 
            simpanTmbl.Location = new Point(42, 347);
            simpanTmbl.Name = "simpanTmbl";
            simpanTmbl.Size = new Size(99, 38);
            simpanTmbl.TabIndex = 3;
            simpanTmbl.Text = "Simpan";
            simpanTmbl.UseVisualStyleBackColor = true;
            simpanTmbl.Click += button3_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(182, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(606, 382);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 376);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(306, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(297, 376);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(simpanTmbl);
            Controls.Add(rekamTmbl);
            Controls.Add(mulaiTmbl);
            Controls.Add(comboBoxWebcam);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxWebcam;
        private Button mulaiTmbl;
        private Button rekamTmbl;
        private Button simpanTmbl;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}