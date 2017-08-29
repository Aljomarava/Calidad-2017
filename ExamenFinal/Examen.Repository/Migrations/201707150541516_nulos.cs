namespace Examen.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nulos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Evaluacion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pregunta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EvaluacionId = c.Int(nullable: false),
                        Texto = c.String(nullable: false, maxLength: 250),
                        OpcionMarcada = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Evaluacion", t => t.EvaluacionId, cascadeDelete: true)
                .Index(t => t.EvaluacionId);
            
            CreateTable(
                "dbo.Opcion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Texto = c.String(nullable: false, maxLength: 250),
                        PreguntaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pregunta", t => t.PreguntaId, cascadeDelete: true)
                .Index(t => t.PreguntaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Opcion", "PreguntaId", "dbo.Pregunta");
            DropForeignKey("dbo.Pregunta", "EvaluacionId", "dbo.Evaluacion");
            DropIndex("dbo.Opcion", new[] { "PreguntaId" });
            DropIndex("dbo.Pregunta", new[] { "EvaluacionId" });
            DropTable("dbo.Opcion");
            DropTable("dbo.Pregunta");
            DropTable("dbo.Evaluacion");
        }
    }
}
