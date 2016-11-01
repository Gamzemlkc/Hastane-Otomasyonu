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
    public partial class HastaListeleForm : ListeleBaseForm
    {
        public HastaListeleForm()
        {
            InitializeComponent();
        }

        private void HastaListeleForm_Load(object sender, EventArgs e)
        {
            var HastalariListele = new HastaRepo().GetALL().ToList();
            lstListe.DisplayMember = "HastaAdi";
            lstListe.ValueMember = "HastaID";
            lstListe.DataSource = HastalariListele;
        }
        public Hasta secilihasta { get; set; }
        public List<Hasta> Hastalar { get; set; }
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListe.SelectedItem == null)
            {
                secilihasta = null;
                return;
            }
            secilihasta = lstListe.SelectedItem as Hasta;
            txtAd.Text = secilihasta.HastaAdi;
            txtSoyad.Text = secilihasta.HastaSoyadi;
            txtTCKN.Text = secilihasta.TcNO;
            txtTelefon.Text = secilihasta.Telefon;
            cmbCinsiyet.Text = secilihasta.Cinsiyet.ToString();
            cmbKanGrubu.Text = secilihasta.Kangrubu.ToString();
       
        }
    }
}
