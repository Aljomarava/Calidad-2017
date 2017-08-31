namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class apoderdoubigeo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ubigeo", "PaisId", "dbo.Pais");
            CreateTable(
                "dbo.Apoderado",
                c => new
                    {
                        ApoderadoId = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 50),
                        Apellidos = c.String(nullable: false, maxLength: 80),
                        Dni = c.String(nullable: false, maxLength: 8),
                        masculino = c.Boolean(nullable: false),
                        Femenino = c.Boolean(nullable: false),
                        Celular = c.String(nullable: false, maxLength: 9),
                        Direccion = c.String(nullable: false, maxLength: 40),
                        UbigeoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ApoderadoId)
                .ForeignKey("dbo.Ubigeo", t => t.UbigeoId)
                .Index(t => t.UbigeoId);
            
            CreateTable(
                "dbo.Alumnos",
                c => new
                    {
                        AlumnoId = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 50),
                        Apellidos = c.String(nullable: false, maxLength: 80),
                        Dni = c.String(nullable: false, maxLength: 8),
                        FechaNacimiento = c.DateTime(nullable: false),
                        masculino = c.Boolean(nullable: false),
                        Femenino = c.Boolean(nullable: false),
                        Celular = c.String(nullable: false, maxLength: 9),
                        Direccion = c.String(nullable: false, maxLength: 40),
                        ApoderadoId = c.Int(nullable: false),
                        UbigeoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlumnoId)
                .ForeignKey("dbo.Apoderado", t => t.ApoderadoId)
                .ForeignKey("dbo.Ubigeo", t => t.UbigeoId)
                .Index(t => t.ApoderadoId)
                .Index(t => t.UbigeoId);
            
            CreateTable(
                "dbo.Documentos",
                c => new
                    {
                        DocumentosId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Estado = c.Boolean(nullable: false),
                        AlumnoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DocumentosId)
                .ForeignKey("dbo.Alumnos", t => t.AlumnoId)
                .Index(t => t.AlumnoId);
            
            CreateTable(
                "dbo.Matricula",
                c => new
                    {
                        MatriculaId = c.Int(nullable: false, identity: true),
                        AlumnoId = c.Int(nullable: false),
                        ApoderadoId = c.Int(nullable: false),
                        AnioAcademicoId = c.Int(nullable: false),
                        SeccionId = c.Int(nullable: false),
                        ParentescoId = c.Int(nullable: false),
                        RegularId = c.Int(),
                        CursoId = c.Int(),
                        NotasId = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.MatriculaId)
                .ForeignKey("dbo.Alumnos", t => t.AlumnoId)
                .ForeignKey("dbo.Seccion", t => t.SeccionId)
                .ForeignKey("dbo.AnioAcademico", t => t.AnioAcademicoId)
                .ForeignKey("dbo.Apoderado", t => t.ApoderadoId)
                .ForeignKey("dbo.Parentesco", t => t.ParentescoId)
                .ForeignKey("dbo.Curso", t => t.CursoId)
                .ForeignKey("dbo.Notas", t => t.NotasId)
                .Index(t => t.AlumnoId)
                .Index(t => t.ApoderadoId)
                .Index(t => t.AnioAcademicoId)
                .Index(t => t.SeccionId)
                .Index(t => t.ParentescoId)
                .Index(t => t.CursoId)
                .Index(t => t.NotasId);
            
            CreateTable(
                "dbo.AnioAcademico",
                c => new
                    {
                        AnioAcademicoId = c.Int(nullable: false, identity: true),
                        Activo = c.Boolean(nullable: false),
                        FechaApertura = c.DateTime(nullable: false),
                        FechaClausura = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AnioAcademicoId);
            
            CreateTable(
                "dbo.Horario",
                c => new
                    {
                        HorarioId = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        HoraInicio = c.DateTime(nullable: false),
                        Horafin = c.DateTime(nullable: false),
                        CursoId = c.Int(nullable: false),
                        AnioAcademicoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HorarioId)
                .ForeignKey("dbo.AnioAcademico", t => t.AnioAcademicoId)
                .ForeignKey("dbo.Curso", t => t.CursoId)
                .Index(t => t.CursoId)
                .Index(t => t.AnioAcademicoId);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 70),
                        SeccionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CursoId)
                .ForeignKey("dbo.Seccion", t => t.SeccionId)
                .Index(t => t.SeccionId);
            
            CreateTable(
                "dbo.Docente",
                c => new
                    {
                        DocenteId = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 50),
                        Apellidos = c.String(nullable: false, maxLength: 80),
                        correo = c.String(nullable: false, maxLength: 8),
                        masculino = c.Boolean(nullable: false),
                        Femenino = c.Boolean(nullable: false),
                        Celular = c.String(nullable: false, maxLength: 9),
                        Direccion = c.String(nullable: false, maxLength: 40),
                        EspecialidadId = c.Int(nullable: false),
                        CursoId = c.Int(nullable: false),
                        UbigeoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DocenteId)
                .ForeignKey("dbo.Curso", t => t.CursoId)
                .ForeignKey("dbo.Especialidad", t => t.EspecialidadId)
                .ForeignKey("dbo.Ubigeo", t => t.UbigeoId)
                .Index(t => t.EspecialidadId)
                .Index(t => t.CursoId)
                .Index(t => t.UbigeoId);
            
            CreateTable(
                "dbo.Especialidad",
                c => new
                    {
                        EspecialidadId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.EspecialidadId);
            
            CreateTable(
                "dbo.Notas",
                c => new
                    {
                        NotasId = c.Int(nullable: false, identity: true),
                        BimestreId = c.Int(nullable: false),
                        AlumnoId = c.Int(nullable: false),
                        CursoId = c.Int(nullable: false),
                        Nota = c.Int(nullable: false),
                        fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.NotasId)
                .ForeignKey("dbo.Alumnos", t => t.AlumnoId)
                .ForeignKey("dbo.Bimestre", t => t.BimestreId)
                .ForeignKey("dbo.Curso", t => t.CursoId)
                .Index(t => t.BimestreId)
                .Index(t => t.AlumnoId)
                .Index(t => t.CursoId);
            
            CreateTable(
                "dbo.Bimestre",
                c => new
                    {
                        BimestreId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 30),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BimestreId);
            
            CreateTable(
                "dbo.Seccion",
                c => new
                    {
                        SeccionId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Capacidad = c.Int(nullable: false),
                        GradoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SeccionId)
                .ForeignKey("dbo.Grado", t => t.GradoId)
                .Index(t => t.GradoId);
            
            CreateTable(
                "dbo.Grado",
                c => new
                    {
                        GradoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        NivelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GradoId)
                .ForeignKey("dbo.Nivel", t => t.NivelId)
                .Index(t => t.NivelId);
            
            CreateTable(
                "dbo.Nivel",
                c => new
                    {
                        NivelId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.NivelId);
            
            CreateTable(
                "dbo.Parentesco",
                c => new
                    {
                        ParentescoId = c.Int(nullable: false, identity: true),
                        tipo = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ParentescoId);
            
            AddForeignKey("dbo.Ubigeo", "PaisId", "dbo.Pais", "PaisId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ubigeo", "PaisId", "dbo.Pais");
            DropForeignKey("dbo.Alumnos", "UbigeoId", "dbo.Ubigeo");
            DropForeignKey("dbo.Matricula", "NotasId", "dbo.Notas");
            DropForeignKey("dbo.Matricula", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.Matricula", "ParentescoId", "dbo.Parentesco");
            DropForeignKey("dbo.Matricula", "ApoderadoId", "dbo.Apoderado");
            DropForeignKey("dbo.Matricula", "AnioAcademicoId", "dbo.AnioAcademico");
            DropForeignKey("dbo.Matricula", "SeccionId", "dbo.Seccion");
            DropForeignKey("dbo.Seccion", "GradoId", "dbo.Grado");
            DropForeignKey("dbo.Grado", "NivelId", "dbo.Nivel");
            DropForeignKey("dbo.Curso", "SeccionId", "dbo.Seccion");
            DropForeignKey("dbo.Notas", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.Notas", "BimestreId", "dbo.Bimestre");
            DropForeignKey("dbo.Notas", "AlumnoId", "dbo.Alumnos");
            DropForeignKey("dbo.Horario", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.Docente", "UbigeoId", "dbo.Ubigeo");
            DropForeignKey("dbo.Apoderado", "UbigeoId", "dbo.Ubigeo");
            DropForeignKey("dbo.Docente", "EspecialidadId", "dbo.Especialidad");
            DropForeignKey("dbo.Docente", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.Horario", "AnioAcademicoId", "dbo.AnioAcademico");
            DropForeignKey("dbo.Matricula", "AlumnoId", "dbo.Alumnos");
            DropForeignKey("dbo.Documentos", "AlumnoId", "dbo.Alumnos");
            DropForeignKey("dbo.Alumnos", "ApoderadoId", "dbo.Apoderado");
            DropIndex("dbo.Grado", new[] { "NivelId" });
            DropIndex("dbo.Seccion", new[] { "GradoId" });
            DropIndex("dbo.Notas", new[] { "CursoId" });
            DropIndex("dbo.Notas", new[] { "AlumnoId" });
            DropIndex("dbo.Notas", new[] { "BimestreId" });
            DropIndex("dbo.Docente", new[] { "UbigeoId" });
            DropIndex("dbo.Docente", new[] { "CursoId" });
            DropIndex("dbo.Docente", new[] { "EspecialidadId" });
            DropIndex("dbo.Curso", new[] { "SeccionId" });
            DropIndex("dbo.Horario", new[] { "AnioAcademicoId" });
            DropIndex("dbo.Horario", new[] { "CursoId" });
            DropIndex("dbo.Matricula", new[] { "NotasId" });
            DropIndex("dbo.Matricula", new[] { "CursoId" });
            DropIndex("dbo.Matricula", new[] { "ParentescoId" });
            DropIndex("dbo.Matricula", new[] { "SeccionId" });
            DropIndex("dbo.Matricula", new[] { "AnioAcademicoId" });
            DropIndex("dbo.Matricula", new[] { "ApoderadoId" });
            DropIndex("dbo.Matricula", new[] { "AlumnoId" });
            DropIndex("dbo.Documentos", new[] { "AlumnoId" });
            DropIndex("dbo.Alumnos", new[] { "UbigeoId" });
            DropIndex("dbo.Alumnos", new[] { "ApoderadoId" });
            DropIndex("dbo.Apoderado", new[] { "UbigeoId" });
            DropTable("dbo.Parentesco");
            DropTable("dbo.Nivel");
            DropTable("dbo.Grado");
            DropTable("dbo.Seccion");
            DropTable("dbo.Bimestre");
            DropTable("dbo.Notas");
            DropTable("dbo.Especialidad");
            DropTable("dbo.Docente");
            DropTable("dbo.Curso");
            DropTable("dbo.Horario");
            DropTable("dbo.AnioAcademico");
            DropTable("dbo.Matricula");
            DropTable("dbo.Documentos");
            DropTable("dbo.Alumnos");
            DropTable("dbo.Apoderado");
            AddForeignKey("dbo.Ubigeo", "PaisId", "dbo.Pais", "PaisId", cascadeDelete: true);
        }
    }
}
