﻿namespace EditorApp
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
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            miYeni = new ToolStripMenuItem();
            miAc = new ToolStripMenuItem();
            miKaydet = new ToolStripMenuItem();
            farklıKaydetToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            düzenToolStripMenuItem = new ToolStripMenuItem();
            miKes = new ToolStripMenuItem();
            miKopyala = new ToolStripMenuItem();
            miYapistir = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            bulToolStripMenuItem = new ToolStripMenuItem();
            görünümToolStripMenuItem = new ToolStripMenuItem();
            temalarToolStripMenuItem = new ToolStripMenuItem();
            koyuTemaToolStripMenuItem = new ToolStripMenuItem();
            açıkTemaToolStripMenuItem = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbYeni = new ToolStripButton();
            tsbAc = new ToolStripButton();
            tsbKaydet = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbKes = new ToolStripButton();
            tsbKopyala = new ToolStripButton();
            tsbYapistir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbBul = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton8 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            txtBelge = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            hakıkımdaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, düzenToolStripMenuItem, görünümToolStripMenuItem, yardımToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miYeni, miAc, miKaydet, farklıKaydetToolStripMenuItem, toolStripMenuItem1, çıkışToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(51, 20);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // miYeni
            // 
            miYeni.Name = "miYeni";
            miYeni.Size = new Size(141, 22);
            miYeni.Text = "Yeni";
            miYeni.Click += miYeni_Click;
            // 
            // miAc
            // 
            miAc.Name = "miAc";
            miAc.Size = new Size(141, 22);
            miAc.Text = "Aç";
            miAc.Click += tsbAc_Click;
            // 
            // miKaydet
            // 
            miKaydet.Name = "miKaydet";
            miKaydet.Size = new Size(141, 22);
            miKaydet.Text = "Kaydet";
            miKaydet.Click += tsbKaydet_Click;
            // 
            // farklıKaydetToolStripMenuItem
            // 
            farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            farklıKaydetToolStripMenuItem.Size = new Size(141, 22);
            farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(138, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(141, 22);
            çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // düzenToolStripMenuItem
            // 
            düzenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miKes, miKopyala, miYapistir, toolStripMenuItem2, bulToolStripMenuItem });
            düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            düzenToolStripMenuItem.Size = new Size(52, 20);
            düzenToolStripMenuItem.Text = "Düzen";
            // 
            // miKes
            // 
            miKes.Name = "miKes";
            miKes.Size = new Size(116, 22);
            miKes.Text = "Kes";
            miKes.Click += miKes_Click;
            // 
            // miKopyala
            // 
            miKopyala.Name = "miKopyala";
            miKopyala.Size = new Size(116, 22);
            miKopyala.Text = "Kopyala";
            miKopyala.Click += miKopyala_Click;
            // 
            // miYapistir
            // 
            miYapistir.Name = "miYapistir";
            miYapistir.Size = new Size(116, 22);
            miYapistir.Text = "Yapıştır";
            miYapistir.Click += miYapistir_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(113, 6);
            // 
            // bulToolStripMenuItem
            // 
            bulToolStripMenuItem.Name = "bulToolStripMenuItem";
            bulToolStripMenuItem.Size = new Size(116, 22);
            bulToolStripMenuItem.Text = "Bul...";
            // 
            // görünümToolStripMenuItem
            // 
            görünümToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { temalarToolStripMenuItem });
            görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            görünümToolStripMenuItem.Size = new Size(70, 20);
            görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // temalarToolStripMenuItem
            // 
            temalarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { koyuTemaToolStripMenuItem, açıkTemaToolStripMenuItem });
            temalarToolStripMenuItem.Name = "temalarToolStripMenuItem";
            temalarToolStripMenuItem.Size = new Size(115, 22);
            temalarToolStripMenuItem.Text = "Temalar";
            // 
            // koyuTemaToolStripMenuItem
            // 
            koyuTemaToolStripMenuItem.Name = "koyuTemaToolStripMenuItem";
            koyuTemaToolStripMenuItem.Size = new Size(132, 22);
            koyuTemaToolStripMenuItem.Text = "Koyu Tema";
            // 
            // açıkTemaToolStripMenuItem
            // 
            açıkTemaToolStripMenuItem.Name = "açıkTemaToolStripMenuItem";
            açıkTemaToolStripMenuItem.Size = new Size(132, 22);
            açıkTemaToolStripMenuItem.Text = "Açık Tema";
            // 
            // yardımToolStripMenuItem
            // 
            yardımToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hakıkımdaToolStripMenuItem });
            yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            yardımToolStripMenuItem.Size = new Size(56, 20);
            yardımToolStripMenuItem.Text = "Yardım";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Gainsboro;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbYeni, tsbAc, tsbKaydet, toolStripSeparator1, tsbKes, tsbKopyala, tsbYapistir, toolStripSeparator2, tsbBul, toolStripSeparator3, toolStripButton8 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 54);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbYeni
            // 
            tsbYeni.Image = Properties.Resources.new_document;
            tsbYeni.ImageTransparentColor = Color.Magenta;
            tsbYeni.Name = "tsbYeni";
            tsbYeni.Size = new Size(36, 51);
            tsbYeni.Text = "Yeni";
            tsbYeni.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbYeni.Click += tsbYeni_Click;
            // 
            // tsbAc
            // 
            tsbAc.Image = Properties.Resources.folder1;
            tsbAc.ImageTransparentColor = Color.Magenta;
            tsbAc.Name = "tsbAc";
            tsbAc.Size = new Size(36, 51);
            tsbAc.Text = "Aç";
            tsbAc.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbAc.Click += tsbAc_Click;
            // 
            // tsbKaydet
            // 
            tsbKaydet.Image = Properties.Resources.diskette;
            tsbKaydet.ImageTransparentColor = Color.Magenta;
            tsbKaydet.Name = "tsbKaydet";
            tsbKaydet.Size = new Size(47, 51);
            tsbKaydet.Text = "Kaydet";
            tsbKaydet.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbKaydet.Click += tsbKaydet_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // tsbKes
            // 
            tsbKes.Image = Properties.Resources.Pictogrammers_Material_Content_cut_32;
            tsbKes.ImageTransparentColor = Color.Magenta;
            tsbKes.Name = "tsbKes";
            tsbKes.Size = new Size(36, 51);
            tsbKes.Text = "Kes";
            tsbKes.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbKes.ToolTipText = "Kesmek için tıklayın";
            tsbKes.Click += miKes_Click;
            // 
            // tsbKopyala
            // 
            tsbKopyala.Image = Properties.Resources.Amitjakhu_Drip_Copy_32;
            tsbKopyala.ImageTransparentColor = Color.Magenta;
            tsbKopyala.Name = "tsbKopyala";
            tsbKopyala.Size = new Size(53, 51);
            tsbKopyala.Text = "Kopyala";
            tsbKopyala.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbKopyala.Click += miKopyala_Click;
            // 
            // tsbYapistir
            // 
            tsbYapistir.Image = Properties.Resources.Fa_Team_Fontawesome_FontAwesome_Paste_32;
            tsbYapistir.ImageTransparentColor = Color.Magenta;
            tsbYapistir.Name = "tsbYapistir";
            tsbYapistir.Size = new Size(49, 51);
            tsbYapistir.Text = "Yapıştır";
            tsbYapistir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbYapistir.Click += miYapistir_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 54);
            // 
            // tsbBul
            // 
            tsbBul.Image = Properties.Resources.search_1124699__1_;
            tsbBul.ImageTransparentColor = Color.Magenta;
            tsbBul.Name = "tsbBul";
            tsbBul.Size = new Size(36, 51);
            tsbBul.Text = "Bul";
            tsbBul.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBul.Click += tsbBul_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 54);
            // 
            // toolStripButton8
            // 
            toolStripButton8.Image = Properties.Resources.chat_5251270;
            toolStripButton8.ImageTransparentColor = Color.Magenta;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(65, 51);
            toolStripButton8.Text = "Hakkımda";
            toolStripButton8.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(34, 17);
            toolStripStatusLabel1.Text = "Hazır";
            // 
            // txtBelge
            // 
            txtBelge.Dock = DockStyle.Fill;
            txtBelge.Location = new Point(0, 78);
            txtBelge.Multiline = true;
            txtBelge.Name = "txtBelge";
            txtBelge.Size = new Size(800, 350);
            txtBelge.TabIndex = 3;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Title = "Dosya Kaydet";
            // 
            // hakıkımdaToolStripMenuItem
            // 
            hakıkımdaToolStripMenuItem.Name = "hakıkımdaToolStripMenuItem";
            hakıkımdaToolStripMenuItem.Size = new Size(180, 22);
            hakıkımdaToolStripMenuItem.Text = "Hakkımda";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBelge);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem miYeni;
        private ToolStripMenuItem miAc;
        private ToolStripMenuItem miKaydet;
        private ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem düzenToolStripMenuItem;
        private ToolStripMenuItem görünümToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStripMenuItem temalarToolStripMenuItem;
        private ToolStripMenuItem koyuTemaToolStripMenuItem;
        private ToolStripMenuItem açıkTemaToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbYeni;
        private ToolStripButton tsbAc;
        private ToolStripButton tsbKaydet;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbKes;
        private ToolStripButton tsbKopyala;
        private ToolStripButton tsbYapistir;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbBul;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton8;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox txtBelge;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem miKes;
        private ToolStripMenuItem miKopyala;
        private ToolStripMenuItem miYapistir;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem bulToolStripMenuItem;
        private ToolStripMenuItem hakıkımdaToolStripMenuItem;
    }
}
