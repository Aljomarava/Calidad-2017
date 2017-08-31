namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class docuemntosentregaalumno : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Documentos", "AlumnoId", "dbo.Alumnos");
            DropIndex("dbo.Documentos", new[] { "AlumnoId" });
            CreateTable(
                "dbo.EntregaDocuentos",
                c => new
                    {
                        EntregaDocuentosId = c.Int(nullable: false, identity: true),
                        DocumentosId = c.Int(nullable: false),
                        AlumnoId = c.Int(nullable: false),
                        Entregado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EntregaDocuentosId)
                .ForeignKey("dbo.Alumnos", t => t.AlumnoId)
                .ForeignKey("dbo.Documentos", t => t.DocumentosId)
                .Index(t => t.DocumentosId)
                .Index(t => t.AlumnoId);
            
            DropColumn("dbo.Documentos", "Estado");
            DropColumn("dbo.Documentos", "AlumnoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Documentos", "AlumnoId", c => c.Int(nullable: false));
            AddColumn("dbo.Documentos", "Estado", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.EntregaDocuentos", "DocumentosId", "dbo.Documentos");
            DropForeignKey("dbo.EntregaDocuentos", "AlumnoId", "dbo.Alumnos");
            DropIndex("dbo.EntregaDocuentos", new[] { "AlumnoId" });
            DropIndex("dbo.EntregaDocuentos", new[] { "DocumentosId" });
            DropTable("dbo.EntregaDocuentos");
            CreateIndex("dbo.Documentos", "AlumnoId");
            AddForeignKey("dbo.Documentos", "AlumnoId", "dbo.Alumnos", "AlumnoId");
        }
    }
}
