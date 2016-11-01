using Hastane.BLL;
using Hastane.Entity;
using Hastane.WFA.BaseForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.WFA.HemsireForm
{
    public partial class HemsireEkleForm : EkleBaseForm
    {
        public HemsireEkleForm()
        {
            InitializeComponent();
        }
        public Doktor SeciliDoktor { get; set; }
        private void HemsireEkleForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Listeler.Cinsiyetler)));
            cmbKanGrubu.Items.AddRange(Enum.GetNames(typeof(Listeler.KanGruplari)));
            cmbBirim.Items.AddRange(Enum.GetNames(typeof(Listeler.Birimler)));
           
         

    }
        public static void listeDoldur<Liste>(ListBox lstHemsire, List<Liste> HemsireListe)
        {
            lstHemsire.Items.Clear();
           
          HemsireListe.ForEach(x => lstHemsire.Items.Add(x));
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
             try
            {
                new HemsireRepo().Insert(new Hemsire()
                {

                    HemsireAdi = txtAd.Text,
                    HemsireSoyadi = txtSoyad.Text,
                    Maas = nuMaas.Value,
                    DogumTarihi = dtpDogumTarihi.Value,
                    TcNO = txtTCKN.Text,
                    Telefon = txtTelefon.Text,
                    Cinsiyet = (Listeler.Cinsiyetler)Enum.Parse(typeof(Listeler.Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                    Kangrubu = (Listeler.KanGruplari)Enum.Parse(typeof(Listeler.KanGruplari), cmbKanGrubu.SelectedItem.ToString()),
                    Birim = (Listeler.Birimler)Enum.Parse(typeof(Listeler.Birimler), cmbBirim.SelectedItem.ToString()),
                    AtandiMi = false
                });
                MessageBox.Show("Hemsire Kaydedilmiştir");
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
       
       
      
    }
}
