using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entity
{
    [Table("Hastalar")]
    public class Hasta
    {
        [Key]
        public int HastaID { get; set; }

        [StringLength(25, MinimumLength = 3, ErrorMessage = "Hasta adi 3-25 karakter arası olmalı")]
        [Column("HastaAdi", TypeName = "varchar")]
        [Required]//boş geçilemez
        public string HastaAdi { get; set; }

        [StringLength(25, MinimumLength = 3, ErrorMessage = "Hasta soyadi 3-25 karakter arası olmalı")]
        [Column("HastaSoyadi", TypeName = "varchar")]
        [Required]
        public string HastaSoyadi { get; set; }
        [StringLength(11, ErrorMessage = "TcNo 11 haneden oluşmalı!!")]
        public string TcNO { get; set; }
        public string Telefon { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Listeler.KanGruplari Kangrubu { get; set; }
        public Listeler.Cinsiyetler Cinsiyet { get; set; }

        public virtual List<Randevu> Randevular { get; set; } = new List<Randevu>();

    }
}
