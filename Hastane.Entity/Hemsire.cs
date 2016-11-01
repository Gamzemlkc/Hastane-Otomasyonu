using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Hastane.Entity.Listeler;

namespace Hastane.Entity
{
    [Table("Hemsireler")]
    public class Hemsire
    {
        [Key]
        public int HemsireID { get; set; }
        
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Hemsire adi 3-25 karakter arası olmalı")]
        [Column("HemsireAdi", TypeName = "varchar")]
        [Required]//boş geçilemez
        public string HemsireAdi { get; set; }

        [StringLength(25, MinimumLength = 3, ErrorMessage = "Hemsire soyadi 3-25 karakter arası olmalı")]
        [Column("HemsireSoyadi", TypeName = "varchar")]
        [Required]
        public string HemsireSoyadi { get; set; }
        [StringLength(11, ErrorMessage = "TcNo 11 haneden oluşmalı!!")]
        public string TcNO { get; set; }
        public string Telefon { get; set; }
        public bool? AtandiMi { get; set; } = false;
        public DateTime DogumTarihi { get; set; }
        public decimal Maas { get; set; }
        public Cinsiyetler Cinsiyet { get; set; }
        public KanGruplari Kangrubu { get; set; }
        public Birimler Birim { get; set; }
        public int? DoktorID { get; set; }

        [ForeignKey("DoktorID")]
        public virtual Doktor Doktoru { get; set; }
        public override string ToString()
        {
            return HemsireAdi + " " + HemsireSoyadi;
        }
    }
}
