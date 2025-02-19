namespace EditorApp
{
    partial class FrmBul
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
            label1 = new Label();
            txtAranan = new TextBox();
            btnBul = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 0;
            label1.Text = "Aranacak Metin :";
            // 
            // txtAranan
            // 
            txtAranan.BackColor = SystemColors.ButtonHighlight;
            txtAranan.Location = new Point(139, 26);
            txtAranan.Margin = new Padding(4);
            txtAranan.Name = "txtAranan";
            txtAranan.Size = new Size(326, 29);
            txtAranan.TabIndex = 1;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(343, 63);
            btnBul.Margin = new Padding(4);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(110, 35);
            btnBul.TabIndex = 2;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // FrmBul
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 121);
            Controls.Add(btnBul);
            Controls.Add(txtAranan);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBul";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bul...";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAranan;
        private Button btnBul;
    }
}