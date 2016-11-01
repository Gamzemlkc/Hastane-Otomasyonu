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

namespace Hastane.WFA.PersonelForm
{
    public partial class PersonelListeleForm : ListeleBaseForm
    {
        public PersonelListeleForm()
        {
            InitializeComponent();
        }

        private void PersonelListeleForm_Load(object sender, EventArgs e)
        {
            var PersonelleriListele = new PersonelRepo().GetALL().OrderBy(x => x.Gorev).ToList();
            lstListe.DisplayMember = "PersonelAdi";
            lstListe.ValueMember = "PersonelID";
            lstListe.DataSource = PersonelleriListele;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Personel seciliPers { get; set; }
        public List<Personel> Personeller { get; set; }
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null)
            {
                seciliPers = null;
                return;
            }
            seciliPers = lstListe.SelectedItem as Personel;
            txtAd.Text = seciliPers.PersonelAdi;
            txtSoyad.Text = seciliPers.PersonelSoyadi;
            txtTCKN.Text = seciliPers.TcNO;
            txttelefon.Text = seciliPers.Telefon;
            cmbCinsiyet.Text = seciliPers.Cinsiyet.ToString();
            cmbKanGrubu.Text = seciliPers.Kangrubu.ToString();
            cmbGorev.Text = seciliPers.Gorev.ToString();
            nuMaas.Value = seciliPers.Maas;
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
            lstListe.DataSource = new PersonelRepo().PersonelAra(txtAra.Text);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null)
            {
                seciliPers = null;
                return;
            }
            else if (MessageBox.Show($"{seciliPers.PersonelAdi} {seciliPers.PersonelSoyadi} Personeli güncellensin mi ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                using (MyContext db = new MyContext())
                {
                    try
                    {
                        var gncPers = db.Personeller.Where(x => x.PersonelID == seciliPers.PersonelID).FirstOrDefault();
                        gncPers.PersonelAdi = txtAd.Text;
                        gncPers.PersonelSoyadi = txtSoyad.Text;
                        gncPers.Gorev = (Gorevler)Enum.Parse(typeof(Gorevler), cmbGorev.SelectedItem.ToString());
                        gncPers.Kangrubu = (KanGruplari)Enum.Parse(typeof(KanGruplari), cmbKanGrubu.SelectedItem.ToString());
                        gncPers.Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString());
                        gncPers.Maas = nuMaas.Value;
                        gncPers.TcNO = txtTCKN.Text;
                        gncPers.Telefon = txttelefon.Text;
                        gncPers.DogumTarihi = dtpDogumTarihi.Value;

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

                lstListe.DataSource = new PersonelRepo().GetALL().OrderBy(x => x.Gorev).ToList();
            }
            else { return; }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null)
            {
                seciliPers = null;
                return;
            }
            else if (MessageBox.Show($"{seciliPers.PersonelAdi} {seciliPers.PersonelSoyadi} Personeli silinsin mi ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MyContext cn = new MyContext();

                var secilenpersonel = new PersonelRepo().GetByID((lstListe.SelectedItem as Personel).PersonelID);
                new PersonelRepo().Delete(secilenpersonel);
                cn.SaveChanges();
                var PersonelleriListele = new PersonelRepo().GetALL().OrderBy(x => x.Gorev).ToList();
                lstListe.DataSource = PersonelleriListele;
                MessageBox.Show("Personel Silindi");
            }
            else { return; }
        }
    }
}
