namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alumnoedit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumnos", "Correo", c => c.String());
            AddColumn("dbo.Alumnos", "Genero", c => c.String());
            AddColumn("dbo.Alumnos", "Estado", c => c.Boolean(nullable: false));
            DropColumn("dbo.Alumnos", "masculino");
            DropColumn("dbo.Alumnos", "Femenino");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Alumnos", "Femenino", c => c.Boolean(nullable: false));
            AddColumn("dbo.Alumnos", "masculino", c => c.Boolean(nullable: false));
            DropColumn("dbo.Alumnos", "Estado");
            DropColumn("dbo.Alumnos", "Genero");
            DropColumn("dbo.Alumnos", "Correo");
        }
    }
}
