﻿namespace YS_PROJECT
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cikis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_kullanici = new System.Windows.Forms.Label();
            this.btn_Personel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_odaIslem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_demirbasIslem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_satinAlim = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.btn_cikis);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btn_Personel);
            this.panel1.Controls.Add(this.btn_odaIslem);
            this.panel1.Controls.Add(this.btn_demirbasIslem);
            this.panel1.Controls.Add(this.btn_satinAlim);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 622);
            this.panel1.TabIndex = 0;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.BorderRadius = 0;
            this.btn_cikis.ButtonText = "Çıkış";
            this.btn_cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cikis.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cikis.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cikis.Iconimage = global::YS_PROJECT.Properties.Resources.exit;
            this.btn_cikis.Iconimage_right = null;
            this.btn_cikis.Iconimage_right_Selected = null;
            this.btn_cikis.Iconimage_Selected = null;
            this.btn_cikis.IconMarginLeft = 0;
            this.btn_cikis.IconMarginRight = 0;
            this.btn_cikis.IconRightVisible = true;
            this.btn_cikis.IconRightZoom = 0D;
            this.btn_cikis.IconVisible = true;
            this.btn_cikis.IconZoom = 90D;
            this.btn_cikis.IsTab = false;
            this.btn_cikis.Location = new System.Drawing.Point(2, 524);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_cikis.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_cikis.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cikis.selected = false;
            this.btn_cikis.Size = new System.Drawing.Size(250, 60);
            this.btn_cikis.TabIndex = 8;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cikis.Textcolor = System.Drawing.Color.White;
            this.btn_cikis.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.lblTime);
            this.panel6.Location = new System.Drawing.Point(1, 583);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 38);
            this.panel6.TabIndex = 7;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(20, 4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.lbl_kullanici);
            this.panel4.Location = new System.Drawing.Point(1, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 38);
            this.panel4.TabIndex = 6;
            // 
            // lbl_kullanici
            // 
            this.lbl_kullanici.AutoSize = true;
            this.lbl_kullanici.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullanici.ForeColor = System.Drawing.Color.White;
            this.lbl_kullanici.Location = new System.Drawing.Point(2, 6);
            this.lbl_kullanici.Name = "lbl_kullanici";
            this.lbl_kullanici.Size = new System.Drawing.Size(52, 23);
            this.lbl_kullanici.TabIndex = 1;
            this.lbl_kullanici.Text = "Sayın:";
            // 
            // btn_Personel
            // 
            this.btn_Personel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_Personel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_Personel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Personel.BorderRadius = 0;
            this.btn_Personel.ButtonText = "Personel İşlemleri";
            this.btn_Personel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Personel.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Personel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Personel.Iconimage = global::YS_PROJECT.Properties.Resources.personel;
            this.btn_Personel.Iconimage_right = null;
            this.btn_Personel.Iconimage_right_Selected = null;
            this.btn_Personel.Iconimage_Selected = null;
            this.btn_Personel.IconMarginLeft = 0;
            this.btn_Personel.IconMarginRight = 0;
            this.btn_Personel.IconRightVisible = true;
            this.btn_Personel.IconRightZoom = 0D;
            this.btn_Personel.IconVisible = true;
            this.btn_Personel.IconZoom = 90D;
            this.btn_Personel.IsTab = false;
            this.btn_Personel.Location = new System.Drawing.Point(2, 379);
            this.btn_Personel.Name = "btn_Personel";
            this.btn_Personel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_Personel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_Personel.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Personel.selected = false;
            this.btn_Personel.Size = new System.Drawing.Size(250, 60);
            this.btn_Personel.TabIndex = 5;
            this.btn_Personel.Text = "Personel İşlemleri";
            this.btn_Personel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Personel.Textcolor = System.Drawing.Color.White;
            this.btn_Personel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Personel.Click += new System.EventHandler(this.btn_Personel_Click);
            // 
            // btn_odaIslem
            // 
            this.btn_odaIslem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_odaIslem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_odaIslem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_odaIslem.BorderRadius = 0;
            this.btn_odaIslem.ButtonText = "Oda İşlemleri";
            this.btn_odaIslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_odaIslem.DisabledColor = System.Drawing.Color.Gray;
            this.btn_odaIslem.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_odaIslem.Iconimage = global::YS_PROJECT.Properties.Resources.room;
            this.btn_odaIslem.Iconimage_right = null;
            this.btn_odaIslem.Iconimage_right_Selected = null;
            this.btn_odaIslem.Iconimage_Selected = null;
            this.btn_odaIslem.IconMarginLeft = 0;
            this.btn_odaIslem.IconMarginRight = 0;
            this.btn_odaIslem.IconRightVisible = true;
            this.btn_odaIslem.IconRightZoom = 0D;
            this.btn_odaIslem.IconVisible = true;
            this.btn_odaIslem.IconZoom = 90D;
            this.btn_odaIslem.IsTab = false;
            this.btn_odaIslem.Location = new System.Drawing.Point(2, 319);
            this.btn_odaIslem.Name = "btn_odaIslem";
            this.btn_odaIslem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_odaIslem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_odaIslem.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_odaIslem.selected = false;
            this.btn_odaIslem.Size = new System.Drawing.Size(250, 60);
            this.btn_odaIslem.TabIndex = 4;
            this.btn_odaIslem.Text = "Oda İşlemleri";
            this.btn_odaIslem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_odaIslem.Textcolor = System.Drawing.Color.White;
            this.btn_odaIslem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_odaIslem.Click += new System.EventHandler(this.btn_odaIslem_Click);
            // 
            // btn_demirbasIslem
            // 
            this.btn_demirbasIslem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_demirbasIslem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_demirbasIslem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_demirbasIslem.BorderRadius = 0;
            this.btn_demirbasIslem.ButtonText = "Demirbaş İşlemleri";
            this.btn_demirbasIslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_demirbasIslem.DisabledColor = System.Drawing.Color.Gray;
            this.btn_demirbasIslem.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_demirbasIslem.Iconimage = global::YS_PROJECT.Properties.Resources.config;
            this.btn_demirbasIslem.Iconimage_right = null;
            this.btn_demirbasIslem.Iconimage_right_Selected = null;
            this.btn_demirbasIslem.Iconimage_Selected = null;
            this.btn_demirbasIslem.IconMarginLeft = 0;
            this.btn_demirbasIslem.IconMarginRight = 0;
            this.btn_demirbasIslem.IconRightVisible = true;
            this.btn_demirbasIslem.IconRightZoom = 0D;
            this.btn_demirbasIslem.IconVisible = true;
            this.btn_demirbasIslem.IconZoom = 90D;
            this.btn_demirbasIslem.IsTab = false;
            this.btn_demirbasIslem.Location = new System.Drawing.Point(2, 259);
            this.btn_demirbasIslem.Name = "btn_demirbasIslem";
            this.btn_demirbasIslem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_demirbasIslem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_demirbasIslem.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_demirbasIslem.selected = false;
            this.btn_demirbasIslem.Size = new System.Drawing.Size(250, 60);
            this.btn_demirbasIslem.TabIndex = 3;
            this.btn_demirbasIslem.Text = "Demirbaş İşlemleri";
            this.btn_demirbasIslem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_demirbasIslem.Textcolor = System.Drawing.Color.White;
            this.btn_demirbasIslem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_demirbasIslem.Click += new System.EventHandler(this.btn_demirbasIslem_Click);
            // 
            // btn_satinAlim
            // 
            this.btn_satinAlim.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_satinAlim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_satinAlim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_satinAlim.BorderRadius = 0;
            this.btn_satinAlim.ButtonText = "Satın Alma İşlemleri";
            this.btn_satinAlim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_satinAlim.DisabledColor = System.Drawing.Color.Gray;
            this.btn_satinAlim.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_satinAlim.Iconimage = global::YS_PROJECT.Properties.Resources.demirbas2;
            this.btn_satinAlim.Iconimage_right = null;
            this.btn_satinAlim.Iconimage_right_Selected = null;
            this.btn_satinAlim.Iconimage_Selected = null;
            this.btn_satinAlim.IconMarginLeft = 0;
            this.btn_satinAlim.IconMarginRight = 0;
            this.btn_satinAlim.IconRightVisible = true;
            this.btn_satinAlim.IconRightZoom = 0D;
            this.btn_satinAlim.IconVisible = true;
            this.btn_satinAlim.IconZoom = 90D;
            this.btn_satinAlim.IsTab = false;
            this.btn_satinAlim.Location = new System.Drawing.Point(2, 199);
            this.btn_satinAlim.Name = "btn_satinAlim";
            this.btn_satinAlim.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_satinAlim.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_satinAlim.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_satinAlim.selected = false;
            this.btn_satinAlim.Size = new System.Drawing.Size(250, 60);
            this.btn_satinAlim.TabIndex = 2;
            this.btn_satinAlim.Text = "Satın Alma İşlemleri";
            this.btn_satinAlim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_satinAlim.Textcolor = System.Drawing.Color.White;
            this.btn_satinAlim.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_satinAlim.Click += new System.EventHandler(this.btn_satinAlim_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 159);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YS_PROJECT.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(250, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(899, 622);
            this.panel5.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 622);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_satinAlim;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Personel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_odaIslem;
        private Bunifu.Framework.UI.BunifuFlatButton btn_demirbasIslem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_kullanici;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cikis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
    }
}

