using Hastane.Entity;
using Hastanee.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.BLL
{
    public class HastaRepo : RepositoryBase<Hasta, int>
    {
        public override void Insert(Hasta entity)
        {
            base.Insert(entity);
        }
        public override void Delete(Hasta entity)
        {
            var silinecekHasta = this.GetByID(entity.HastaID);
            dbContext.SaveChanges();
        }
        MyContext myct;
        public void Update(Hasta entity)
        {
            myct.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            myct.SaveChanges();
        }
        public List<Hasta> HastaAra(string kelime)
        {
            string arananHasta = kelime.ToLower();
            return this.GetALL().Where( x => x.HastaAdi.ToLower().Contains(arananHasta) || x.HastaSoyadi.ToLower().Contains(arananHasta)).ToList();
        }

    }
    public class PersonelRepo : RepositoryBase<Personel, int>
    {
        public override void Insert(Personel entity)
        {
            base.Insert(entity);
        }
        public override void Delete(Personel entity)
        {
            var silinecekPersonel = this.GetByID(entity.PersonelID);
            dbContext.SaveChanges();
        }
        MyContext myct;
        public void Update(Personel entity)
        {
            myct.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            myct.SaveChanges();
        }
        public List<Personel> PersonelAra(string kelime)
        {
            string arananPersonel = kelime.ToLower();
            return this.GetALL().Where(x => x.PersonelAdi.ToLower().Contains(arananPersonel) || x.PersonelSoyadi.ToLower().Contains(arananPersonel)).ToList();
        }
    }
    public class HemsireRepo : RepositoryBase<Hemsire, int>
    {
        MyContext myct;
        public override void Insert(Hemsire entity)
        {
            base.Insert(entity);
        }
        public override void Delete(Hemsire entity)
        {
            var silinecekHemsire = this.GetByID(entity.HemsireID);
            dbContext.SaveChanges();
        }
        
        public void Update(Hemsire entity)
        {
            myct.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            myct.SaveChanges();   
        }
        public List<Hemsire> HemsireAra(string kelime)
        {
            string arananHemsire = kelime.ToLower();
            return this.GetALL().Where(x => x.HemsireAdi.ToLower().Contains(arananHemsire) || x.HemsireSoyadi.ToLower().Contains(arananHemsire)).ToList();
        }
      
    }
    public class DoktorRepo : RepositoryBase<Doktor, int>
    {
    
        public override void Insert(Doktor entity)
        {
            base.Insert(entity);
        }
        public override void Delete(Doktor entity)
        {
            var silinecekDoktor = this.GetByID(entity.DoktorID);
            dbContext.SaveChanges();
        }
        MyContext myct;
        public void Update(Hemsire entity)
        {
            myct.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            myct.SaveChanges();
        }
        public List<Doktor> DoktorAra(string kelime)
        {
            string arananDoktor = kelime.ToLower();
            return this.GetALL().Where(x => x.DoktorAdi.ToLower().Contains(arananDoktor) || x.DoktorSoyadi.ToLower().Contains(arananDoktor)).ToList();
        }
    }
    public class RandevuRepo : RepositoryBase<Randevu, int>
    {
        public override void Insert(Randevu entity)
        {
            base.Insert(entity);
        }
        public override void Delete(Randevu entity)
        {
            throw new Exception("Randevuyu silemezsiniz !");
        }
        MyContext myct;
        public void Update(Hemsire entity)
        {
            myct.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            myct.SaveChanges();
        }
    }
}
