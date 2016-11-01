namespace Hastanee.DAL
{
    using Hastane.Entity;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyContext : DbContext
    {
        // Your context has been configured to use a 'MyContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Hastanee.DAL.MyContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MyContext' 
        // connection string in the application configuration file.
        public MyContext()
            : base("name=MyContext")
        {
        }
        public virtual DbSet<Doktor> Doktorlar { get; set; }
        public virtual DbSet<Hemsire> Hemsireler { get; set; }
        public virtual DbSet<Hasta> Hastalar { get; set; }
        public virtual DbSet<Personel> Personeller { get; set; }
        public virtual DbSet<Randevu> Randevular { get; set; }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}