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

namespace Hastane.WFA.DoktorForm
{
    public partial class DoktorEkleForm : EkleBaseForm
    {
        public DoktorEkleForm()
        {
            InitializeComponent();

        }
        public List<Doktor> Doktorlar { get; set; }
        public List<Hemsire> Hemsireler { get; set; }
        public List<Hemsire> DoktorunHemsireleri { get; set; }
        public Birimler SeciliBirim { get; set; }
        private void DoktorEkleForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyetler)));
            cmbKanGrubu.Items.AddRange(Enum.GetNames(typeof(KanGruplari)));
            cmbUnvan.Items.AddRange(Enum.GetNames(typeof(Unvanlar)));
            cmbBirim.Items.AddRange(Enum.GetNames(typeof(Birimler)));

        }
        public Hemsire secilenhemsire { get; set; }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            secilenhemsire = lstHemsireler.SelectedItem as Hemsire;
            
            try
            {
                new DoktorRepo().Insert(new Doktor()
                {

                    DoktorAdi = txtAd.Text,
                    DoktorSoyadi = txtSoyad.Text,
                    Maas = nuMaas.Value,
                    DogumTarihi = dtpDogumTarihi.Value,
                    TcNO = txtTCKN.Text,
                    Telefon = txtTelefon.Text,
                    Cinsiyet = (Cinsiyetler)Enum.Parse(typeof(Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                    Kangrubu = (KanGruplari)Enum.Parse(typeof(KanGruplari), cmbKanGrubu.SelectedItem.ToString()),
                    Unvan = (Unvanlar)Enum.Parse(typeof(Unvanlar), cmbUnvan.SelectedItem.ToString()),
                    Birim = (Birimler)Enum.Parse(typeof(Birimler), cmbBirim.SelectedItem.ToString()),
                    HemsireID=secilenhemsire.HemsireID
            });

                MessageBox.Show("Doktor Kaydedilmiştir");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle(this.Controls);
        }
        public static void FormTemizle(Control.ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                if (item is TextBox)
                    (item as TextBox).Text = string.Empty;
                else if (item is NumericUpDown)
                    (item as NumericUpDown).Value = 0;
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = 0;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
                else if (item is CheckBox)
                    (item as CheckBox).Checked = false;
            }
        }

        private void lstHemsireler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clsHemsireler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBirim.SelectedIndex == -1) return;

            SeciliBirim = (Birimler)Enum.Parse(typeof(Birimler), cmbBirim.SelectedItem.ToString());
            var atanmamislar = new HemsireRepo().GetALL().Where(x => x.Birim == SeciliBirim && x.AtandiMi == false).ToList();
            lstHemsireler.DataSource = atanmamislar;
           

        }

        private void lstHemsireler_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
