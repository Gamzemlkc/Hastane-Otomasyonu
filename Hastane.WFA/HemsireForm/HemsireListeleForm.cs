using Hastane.BLL;
using Hastane.Entity;
using Hastane.WFA.BaseForm;
using Hastanee.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Hastane.Entity.Listeler;

namespace Hastane.WFA.HemsireForm
{
    public partial class HemsireListeleForm : ListeleBaseForm
    {
        public HemsireListeleForm()
        {
            InitializeComponent();
        }
        List<Hemsire> Hemsireler = new List<Hemsire>();
        private void HemsireListeleForm_Load(object sender, EventArgs e)
        {
            var HemsireleriListele = new HemsireRepo().GetALL().OrderBy(x => x.Birim).ToList();
            lstListe.DisplayMember = "HemsireAdi";
            lstListe.ValueMember = "HemsireID";
            lstListe.DataSource = HemsireleriListele;
        }
        public Hemsire seciliHems { get; set; }
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstListe.SelectedItem == null)
            {
                seciliHems = null;
                return;
            }
            seciliHems = lstListe.SelectedItem as Hemsire;
            txtAd.Text = seciliHems.HemsireAdi;
            txtSoyad.Text = seciliHems.HemsireSoyadi;
            txtTCKN.Text = seciliHems.TcNO;
            txtTelefon.Text = seciliHems.Telefon;
            cmbCinsiyet.Text = seciliHems.Cinsiyet.ToString();
            cmbKanGrubu.Text = seciliHems.Kangrubu.ToString();
            cmbBirim.Text = seciliHems.Birim.ToString();
            nuMaas.Value = seciliHems.Maas;

        }
        public static void TemizleFrm(Control.ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = 0;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
                else if (item is MaskedTextBox)
                    item.Text = string.Empty;
            }
        }
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            lstListe.DataSource = new HemsireRepo().HemsireAra(txtAra.Text);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (lstListe.SelectedItem == null)
            {
                seciliHems = null;
                return;
            }
            else if (MessageBox.Show($"{seciliHems.HemsireAdi} {seciliHems.HemsireSoyadi} Hemşiresi güncellensin mi ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                using (MyContext db = new MyContext())
                {
                    try
                    {
                        var guncellenecekHemsire = db.Hemsireler.Where(x => x.HemsireID == seciliHems.HemsireID).FirstOrDefault();
                        guncellenecekHemsire.HemsireAdi = txtAd.Text;
                        guncellenecekHemsire.HemsireSoyadi = txtSoyad.Text;
                        guncellenecekHemsire.Birim = (Birimler)Enum.Parse(typeof(Birimler), cmbBirim.SelectedItem.ToString());
                        guncellenecekHemsire.Kangrubu = (KanGruplari)Enum.Parse(typeof(KanGruplari), cmbKanGrubu.SelectedItem.ToString());
                        guncellenecekHemsire.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
                        guncellenecekHemsire.Maas = nuMaas.Value;
                        guncellenecekHemsire.TcNO = txtTCKN.Text;
                        guncellenecekHemsire.Telefon = txtTelefon.Text;
                        guncellenecekHemsire.DogumTarihi = dtpDogumTarihi.Value;
                        guncellenecekHemsire.AtandiMi = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        db.SaveChanges();
                        MessageBox.Show("Güncelleme Başarılı");

                    }
                }

                var HemsireleriListele = new HemsireRepo().GetALL().OrderBy(x=>x.Birim).ToList();
                lstListe.DataSource = HemsireleriListele;
            }
            else { return; }
        }

        private void cmbBirim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public Hemsire secili { get; set; }
       
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null)
            {
                seciliHems = null;
                return;
            }
            else if (MessageBox.Show($"{seciliHems.HemsireAdi} {seciliHems.HemsireSoyadi} Hemşiresi silinsin mi ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MyContext db = new MyContext())

                {
                    try
                    {
                        secili = lstListe.SelectedItem as Hemsire;
                        var secilenhems = new HemsireRepo().GetByID(secili.HemsireID);
                        new HemsireRepo().Delete(secilenhems);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        
                        MessageBox.Show("Hemsire Silindi");
                    }
                }
                var HemsireleriListele = new HemsireRepo().GetALL().OrderBy(x=>x.Birim).ToList();
                lstListe.DataSource = HemsireleriListele;
            }
        }  }
        }
