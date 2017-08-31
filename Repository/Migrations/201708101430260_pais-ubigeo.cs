namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class paisubigeo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pais",
                c => new
                    {
                        PaisId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PaisId);
            
            CreateTable(
                "dbo.Ubigeo",
                c => new
                    {
                        UbigeoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 80),
                        Departamento = c.String(nullable: false, maxLength: 80),
                        Provincia = c.String(nullable: false, maxLength: 80),
                        Distrito = c.String(nullable: false, maxLength: 80),
                        PaisId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UbigeoId)
                .ForeignKey("dbo.Pais", t => t.PaisId, cascadeDelete: true)
                .Index(t => t.PaisId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ubigeo", "PaisId", "dbo.Pais");
            DropIndex("dbo.Ubigeo", new[] { "PaisId" });
            DropTable("dbo.Ubigeo");
            DropTable("dbo.Pais");
        }
    }
}
