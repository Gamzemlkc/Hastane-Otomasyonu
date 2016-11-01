using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entity
{
    [Table("Randevular")]
    public class Randevu
    {
        [Key]
        public Guid RandevuID { get; set; } 
        public int HastaID { get; set; }
        public int DoktorID { get; set; }
        public DateTime RandevuAlmaZamani { get; set; } = DateTime.Now;
        public int SiraNumarasi { get; set; }

        [ForeignKey("DoktorID")]
        public virtual Doktor Doktor { get; set; }

        [ForeignKey("HastaID")]
        public virtual Hasta Hasta { get; set; }

    }
}
