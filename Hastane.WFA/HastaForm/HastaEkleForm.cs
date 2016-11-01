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

namespace Hastane.WFA.HastaForm
{
    public partial class HastaEkleForm : EkleBaseForm
    {
        public HastaEkleForm()
        {
            InitializeComponent();
        }

        private void HastaEkleForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Listeler.Cinsiyetler)));
            cmbKanGrubu.Items.AddRange(Enum.GetNames(typeof(Listeler.KanGruplari)));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                new HastaRepo().Insert(new Hasta()
                {

                    HastaAdi = txtAd.Text,
                    HastaSoyadi = txtSoyad.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    TcNO = txtTCKN.Text,
                    Telefon = txtTelefon.Text,
                    Cinsiyet = (Listeler.Cinsiyetler)Enum.Parse(typeof(Listeler.Cinsiyetler), cmbCinsiyet.SelectedItem.ToString()),
                    Kangrubu = (Listeler.KanGruplari)Enum.Parse(typeof(Listeler.KanGruplari), cmbKanGrubu.SelectedItem.ToString())
                   
                });
                MessageBox.Show("Hasta Kaydedilmiştir");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
