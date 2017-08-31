namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alumnosinapoderado : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Alumnos", "ApoderadoId", "dbo.Apoderado");
            DropIndex("dbo.Alumnos", new[] { "ApoderadoId" });
            DropColumn("dbo.Alumnos", "ApoderadoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Alumnos", "ApoderadoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Alumnos", "ApoderadoId");
            AddForeignKey("dbo.Alumnos", "ApoderadoId", "dbo.Apoderado", "ApoderadoId");
        }
    }
}
