namespace EditorApp
{
    partial class FrmHakkimda
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            btntamam = new Button();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 99);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(139, 78);
            label3.Name = "label3";
            label3.Size = new Size(343, 21);
            label3.TabIndex = 2;
            label3.Text = "----------------------------------------------------------------";
            // 
            // label2
            // 
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(369, 55);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "v.1.0";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(139, 0);
            label1.Name = "label1";
            label1.Size = new Size(343, 78);
            label1.TabIndex = 1;
            label1.Text = "EditorApp";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = Properties.Resources.xbox_logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 157);
            label4.Name = "label4";
            label4.Size = new Size(458, 201);
            label4.TabIndex = 1;
            label4.Text = "Bu Uygulama Torbalı Şehit Uzman Harun Şenözüar MTAL Bilişim Bölümü Nesne Tabanlı Programlama dersinde tasarlanmıştır. ";
            // 
            // btntamam
            // 
            btntamam.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btntamam.Location = new Point(283, 446);
            btntamam.Name = "btntamam";
            btntamam.Size = new Size(187, 38);
            btntamam.TabIndex = 3;
            btntamam.Text = "TAMAM";
            btntamam.UseVisualStyleBackColor = true;
            btntamam.Click += btntamam_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.BackColor = Color.WhiteSmoke;
            linkLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            linkLabel1.Location = new Point(59, 321);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(353, 37);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/yigitcobanoglu";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmHakkimda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(482, 496);
            Controls.Add(linkLabel1);
            Controls.Add(btntamam);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "FrmHakkimda";
            Text = "Hakkında";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btntamam;
        private LinkLabel linkLabel1;
    }
}