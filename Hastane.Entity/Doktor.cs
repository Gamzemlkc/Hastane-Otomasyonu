using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entity
{
    [Table("Doktorlar")]
    public class Doktor
    {
        [Key]
        public int DoktorID { get; set; }

        [StringLength(25, MinimumLength = 3, ErrorMessage = "Doktor adi 3-25 karakter arası olmalı")]
        [Column("DoktorAdi", TypeName = "nvarchar")]
        [Required]//boş geçilemez
        public string DoktorAdi { get; set; }

        [StringLength(25, MinimumLength = 3, ErrorMessage = "Doktor soyadi 3-25 karakter arası olmalı")]
        [Column("DoktorSoyadi", TypeName = "nvarchar")]
        [Required]
        public string DoktorSoyadi { get; set; }
        [StringLength(11,ErrorMessage ="TcNo 11 haneden oluşmalı!!")]
        public string TcNO { get; set; }
        public string Telefon { get; set; }
        public DateTime DogumTarihi { get; set; }
        public decimal Maas { get; set; }
        public Listeler.Unvanlar Unvan { get; set; }
        public override string ToString()
        {
            return DoktorAdi;
        }
        public Listeler.Cinsiyetler Cinsiyet { get; set; }
        public Listeler.KanGruplari Kangrubu { get; set; }
        public Listeler.Birimler Birim { get; set; }
        public virtual List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();
        public virtual List<Randevu> Randevular { get; set; } = new List<Randevu>();
        public int HemsireID { get; set; }
    }
}
