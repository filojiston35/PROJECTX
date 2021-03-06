﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YS_PROJECT
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        List<String[]> kullanici;
        OdaIslemleri OS;
        PersonelIslemleri PI;
        SatinAlimIslemleri SA;
        DemirbasIslemleri DI;
        DB_Operation dbo = new DB_Operation();
        List<string> kullaniciBilgi;
        List<string[]> kullaniciAdSoyad;
        public MainScreen(List<String[]> kullanici)
        {
            this.kullanici = kullanici;
            string username = kullanici[0][1];
            kullaniciBilgi = new List<string>() { username };
            InitializeComponent();
            MainScreenYenileme();
        }
        public void MainScreenYenileme()//Kullanıcı girişi yapıldıktran sonra ekranda olacak değişiklikler
        {
            kullaniciAdSoyad = dbo.Select(sqlConnectionString.kullanicininAdiSoyadi, sqlConnectionString.kAS, kullaniciBilgi);
            lbl_kullanici.Text =" "+ kullaniciAdSoyad[0][0] +" "+ kullaniciAdSoyad[0][1];
            lbl_kullanici.Text = lbl_kullanici.Text.ToUpper();
            panel1.Visible = true;
        }

        private void pBox_cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_odaIslem_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            OS = new OdaIslemleri();
            panel5.Controls.Add(OS);
            OS.yetkiKontrol(Convert.ToBoolean(kullanici[0][3]));
            OS.Show();
            NormalRengeDon();
            btn_odaIslem.Normalcolor = Color.FromArgb(255, 0, 172, 209);
        }
        public void NormalRengeDon()
        {
            btn_odaIslem.Normalcolor = Color.FromArgb(255, 1, 179, 227);
            btn_demirbasIslem.Normalcolor = Color.FromArgb(255, 1, 179, 227);
            btn_Personel.Normalcolor = Color.FromArgb(255, 1, 179, 227);
            btn_satinAlim.Normalcolor = Color.FromArgb(255, 1, 179, 227);
        }

        private void btn_Personel_Click(object sender, EventArgs e)
        {
            PI = new PersonelIslemleri();
            panel5.Controls.Clear();
            panel5.Controls.Add(PI);
            PI.yetkiKontrol(kullanici);
            PI.Show();
            NormalRengeDon();
            btn_Personel.Normalcolor = Color.FromArgb(255, 0, 172, 209);
        }

        private void btn_satinAlim_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            if (Convert.ToBoolean(kullanici[0][3]) == false)
                panel5.Controls.Add(new yetkiUyari());
            else
            {
                SA = new SatinAlimIslemleri();
                panel5.Controls.Add(SA);
                SA.yetkiKontrol(Convert.ToBoolean(kullanici[0][3]));
                SA.Show();
                NormalRengeDon();
                btn_satinAlim.Normalcolor = Color.FromArgb(255, 0, 172, 209);
            }
          
        }

        private void btn_demirbasIslem_Click(object sender, EventArgs e)
        {
            DI = new DemirbasIslemleri();
            panel5.Controls.Clear();
            panel5.Controls.Add(DI);
            DI.yetkiKontrol(Convert.ToBoolean(kullanici[0][3]));
            DI.Show();
            NormalRengeDon();
            btn_demirbasIslem.Normalcolor = Color.FromArgb(255, 0, 172, 209);
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lgn = new login();
            lgn.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
              lblTime.Text ="  TARİH : "+DateTime.Now.ToLongDateString()+"\n"+ "   SAAT : " + DateTime.Now.ToLongTimeString();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
