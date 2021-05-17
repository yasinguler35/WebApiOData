namespace WebApiOData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationOData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Isler",
                c => new
                    {
                        isId = c.Int(nullable: false, identity: true),
                        isAd = c.String(),
                    })
                .PrimaryKey(t => t.isId);
            
            CreateTable(
                "dbo.PerIs",
                c => new
                    {
                        perIsId = c.Int(nullable: false, identity: true),
                        perId = c.Int(nullable: false),
                        isId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.perIsId)
                .ForeignKey("dbo.Isler", t => t.isId, cascadeDelete: true)
                .ForeignKey("dbo.Personeller", t => t.perId, cascadeDelete: true)
                .Index(t => t.isId)
                .Index(t => t.perId);
            
            CreateTable(
                "dbo.Personeller",
                c => new
                    {
                        perId = c.Int(nullable: false, identity: true),
                        perAd = c.String(),
                        perSoyad = c.String(),
                        perYas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.perId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PerIs", "perId", "dbo.Personeller");
            DropForeignKey("dbo.PerIs", "isId", "dbo.Isler");
            DropIndex("dbo.PerIs", new[] { "perId" });
            DropIndex("dbo.PerIs", new[] { "isId" });
            DropTable("dbo.Personeller");
            DropTable("dbo.PerIs");
            DropTable("dbo.Isler");
        }
    }
}
