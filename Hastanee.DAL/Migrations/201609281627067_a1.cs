namespace Hastanee.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doktorlar",
                c => new
                    {
                        DoktorID = c.Int(nullable: false, identity: true),
                        DoktorAdi = c.String(nullable: false, maxLength: 25),
                        DoktorSoyadi = c.String(nullable: false, maxLength: 25),
                        TcNO = c.String(maxLength: 11),
                        Telefon = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                        Maas = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Unvan = c.Int(nullable: false),
                        Cinsiyet = c.Int(nullable: false),
                        Kangrubu = c.Int(nullable: false),
                        Birim = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DoktorID);
            
            CreateTable(
                "dbo.Hemsireler",
                c => new
                    {
                        HemsireID = c.Int(nullable: false, identity: true),
                        HemsireAdi = c.String(nullable: false, maxLength: 25, unicode: false),
                        HemsireSoyadi = c.String(nullable: false, maxLength: 25, unicode: false),
                        TcNO = c.String(maxLength: 11),
                        Telefon = c.String(),
                        AtandiMi = c.Boolean(nullable: false),
                        DogumTarihi = c.DateTime(nullable: false),
                        Maas = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cinsiyet = c.Int(nullable: false),
                        Kangrubu = c.Int(nullable: false),
                        Birim = c.Int(nullable: false),
                        DoktorID = c.Int(),
                    })
                .PrimaryKey(t => t.HemsireID)
                .ForeignKey("dbo.Doktorlar", t => t.DoktorID)
                .Index(t => t.DoktorID);
            
            CreateTable(
                "dbo.Randevular",
                c => new
                    {
                        RandevuID = c.Guid(nullable: false),
                        HastaID = c.Int(nullable: false),
                        DoktorID = c.Int(nullable: false),
                        RandevuAlmaZamani = c.DateTime(nullable: false),
                        SiraNumarasi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RandevuID)
                .ForeignKey("dbo.Doktorlar", t => t.DoktorID, cascadeDelete: true)
                .ForeignKey("dbo.Hastalar", t => t.HastaID, cascadeDelete: true)
                .Index(t => t.HastaID)
                .Index(t => t.DoktorID);
            
            CreateTable(
                "dbo.Hastalar",
                c => new
                    {
                        HastaID = c.Int(nullable: false, identity: true),
                        HastaAdi = c.String(nullable: false, maxLength: 25, unicode: false),
                        HastaSoyadi = c.String(nullable: false, maxLength: 25, unicode: false),
                        TcNO = c.String(maxLength: 11),
                        Telefon = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                        Kangrubu = c.Int(nullable: false),
                        Cinsiyet = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HastaID);
            
            CreateTable(
                "dbo.Personeller",
                c => new
                    {
                        PersonelID = c.Int(nullable: false, identity: true),
                        PersonelAdi = c.String(nullable: false, maxLength: 25, unicode: false),
                        PersonelSoyadi = c.String(nullable: false, maxLength: 25, unicode: false),
                        TcNO = c.String(maxLength: 11),
                        Telefon = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                        Maas = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Kangrubu = c.Int(nullable: false),
                        Cinsiyet = c.Int(nullable: false),
                        Gorev = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Randevular", "HastaID", "dbo.Hastalar");
            DropForeignKey("dbo.Randevular", "DoktorID", "dbo.Doktorlar");
            DropForeignKey("dbo.Hemsireler", "DoktorID", "dbo.Doktorlar");
            DropIndex("dbo.Randevular", new[] { "DoktorID" });
            DropIndex("dbo.Randevular", new[] { "HastaID" });
            DropIndex("dbo.Hemsireler", new[] { "DoktorID" });
            DropTable("dbo.Personeller");
            DropTable("dbo.Hastalar");
            DropTable("dbo.Randevular");
            DropTable("dbo.Hemsireler");
            DropTable("dbo.Doktorlar");
        }
    }
}
