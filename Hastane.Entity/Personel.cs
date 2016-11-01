using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entity
{
    [Table("Personeller")]
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }

        [StringLength(25, MinimumLength = 3, ErrorMessage = "Personel adi 3-25 karakter arası olmalı")]
        [Column("PersonelAdi", TypeName = "varchar")]
        [Required]//boş geçilemez
        public string PersonelAdi { get; set; }

        [StringLength(25, MinimumLength = 3, ErrorMessage = "Personel soyadi 3-25 karakter arası olmalı")]
        [Column("PersonelSoyadi", TypeName = "varchar")]
        [Required]
        public string PersonelSoyadi { get; set; }
        [StringLength(11, ErrorMessage = "TcNo 11 haneden oluşmalı!!")]
        public string TcNO { get; set; }
        public string Telefon { get; set; }
        public DateTime DogumTarihi { get; set; }
        public decimal Maas { get; set; }
        public Listeler.KanGruplari Kangrubu { get; set; }
        public Listeler.Cinsiyetler Cinsiyet { get; set; }
        public Listeler.Gorevler Gorev { get; set; }
    }
}
