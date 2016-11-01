using Hastane.WFA.DoktorForm;
using Hastane.WFA.HastaForm;
using Hastane.WFA.HemsireForm;
using Hastane.WFA.PersonelForm;
using Hastane.WFA.RandevuForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PersonelEkleForm frmPersonelEkle;
        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPersonelEkle == null || frmPersonelEkle.IsDisposed)
                frmPersonelEkle = new PersonelEkleForm();
            frmPersonelEkle.MdiParent = this;
            frmPersonelEkle.Text = "Personel Ekleme Formu";
            frmPersonelEkle.Show();
        }
        PersonelListeleForm frmPersonelListele;
        private void personelListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPersonelListele == null || frmPersonelListele.IsDisposed)
                frmPersonelListele = new PersonelListeleForm();
            frmPersonelListele.MdiParent = this;
            frmPersonelListele.Text = "Personel Listele Formu";
            frmPersonelListele.Show();
        }
        HemsireEkleForm frmHemsireEkle;
        private void hemşireEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHemsireEkle == null || frmHemsireEkle.IsDisposed)
                frmHemsireEkle = new HemsireEkleForm();
            frmHemsireEkle.MdiParent = this;
            frmHemsireEkle.Text = "Hemsire Ekleme Formu";
            frmHemsireEkle.Show();
        }
        HemsireListeleForm frmHemsireListele;
        private void hemşireListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHemsireListele == null || frmHemsireListele.IsDisposed)
                frmHemsireListele = new HemsireListeleForm();
            frmHemsireListele.MdiParent = this;
            frmHemsireListele.Text = "Hemşire Listele Formu";
            frmHemsireListele.Show();
        }
        DoktorEkleForm frmDoktorEkle;
        private void doktorEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDoktorEkle == null || frmDoktorEkle.IsDisposed)
                frmDoktorEkle = new DoktorEkleForm();
            frmDoktorEkle.MdiParent = this;
            frmDoktorEkle.Text = "Doktor Ekleme Formu";
            frmDoktorEkle.Show();
        }
        DoktorListeleForm frmDoktorListele;
        private void doktorListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDoktorListele == null || frmDoktorListele.IsDisposed)
                frmDoktorListele = new DoktorListeleForm();
            frmDoktorListele.MdiParent = this;
            frmDoktorListele.Text = "Doktor Listele Formu";
            //frmPersonelEkle.Personeller = this.Context.Personeller;
            frmDoktorListele.Show();
        }
        HastaEkleForm frmHastaEkle;
        private void hastaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHastaEkle == null || frmHastaEkle.IsDisposed)
                frmHastaEkle = new HastaEkleForm();
            frmHastaEkle.MdiParent = this;
            frmHastaEkle.Text = "Hasta Ekleme Formu";
            //frmPersonelEkle.Personeller = this.Context.Personeller;
            frmHastaEkle.Show();
        }
        HastaListeleForm frmHastaListele;
        private void hastaListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHastaListele == null || frmHastaListele.IsDisposed)
                frmHastaListele = new HastaListeleForm();
            frmHastaListele.MdiParent = this;
            frmHastaListele.Text = "Hasta Listele Formu";
            //frmPersonelEkle.Personeller = this.Context.Personeller;
            frmHastaListele.Show();
        }
        RandevuEkleForm frmRandevuEkle;
        private void randevuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRandevuEkle == null || frmRandevuEkle.IsDisposed)
                frmRandevuEkle = new RandevuEkleForm();
            frmRandevuEkle.MdiParent = this;
            frmRandevuEkle.Text = "Randevu Ekleme Formu";
            //frmPersonelEkle.Personeller = this.Context.Personeller;
            frmRandevuEkle.Show();
        }
        RandevuListeleForm frmRandevuListele;

        private void randevuListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRandevuListele == null || frmRandevuListele.IsDisposed)
                frmRandevuListele = new RandevuListeleForm();
            frmRandevuListele.MdiParent = this;
            frmRandevuListele.Text = "Randevu Listele Formu";
            //frmPersonelEkle.Personeller = this.Context.Personeller;
            frmRandevuListele.Show();
        }

        private void hemşireToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
