using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Entity
{
  public  class Listeler
    {

    
        public enum Cinsiyetler
        {
            Belirsiz,
            Erkek,
            Kadın
        }
        public enum KanGruplari
        {
            SifirRhPozitif,
            SifirRhNegatif,
            ARhPozitif,
            ARhNegatif,
            BRhPozitif,
            BRhNegatif,
            ABRhPozitif,
            ABRhNegatif
        }
        public enum Birimler
        {
            Dahiliye,
            Ortopedi,
            Göz,
            Cildiye,
            KBB,
            Çocuk
        }
        public enum Gorevler
        {
            Muhasebe,
            Temizlik,
            Hastabakici
        }
        public enum Unvanlar
        {
            ProfDr,
            DocDr,
            UzDr,
            PratisyenDr
        }
    }
}
