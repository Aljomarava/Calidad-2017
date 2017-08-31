namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cursogradoseccion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Curso", "GradoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Curso", "GradoId");
            AddForeignKey("dbo.Curso", "GradoId", "dbo.Grado", "GradoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Curso", "GradoId", "dbo.Grado");
            DropIndex("dbo.Curso", new[] { "GradoId" });
            DropColumn("dbo.Curso", "GradoId");
        }
    }
}
