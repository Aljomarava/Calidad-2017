using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Repository
{
    public partial  class SystemContext:DbContext
    {
        public SystemContext()
        {
            
            this.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Alumno> alumnos { get; set; }
        public DbSet<Apoderado> apoderados { get; set; }
        public DbSet<Pais> paises { get; set; }
        public DbSet<Ubigeo> ubigeos { get; set; }
        public DbSet<Notas> notas { get; set; }
        public DbSet<Curso> cursos { get; set; }
        public DbSet<Docente> docentes { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<EntregaDocuentos> entregaDocuentos { get; set; }
        public DbSet<Bimestre> bimestres { get; set; }
        public DbSet<Documentos> documentos { get; set; }
        public DbSet<Horario> horarios { get; set; }
        public DbSet<Nivel> niveles { get; set; }
        public DbSet<Grado> grados { get; set; }
        public DbSet<Seccion> secciones { get; set; }
        public DbSet<AnioAcademico> anioAcademicos { get; set; }
        public DbSet<Matricula> matriculas { get; set; }
        public DbSet<MatriculaReegular> matricularegular { get; set; }
        public DbSet<Parentesco> parentesco { get; set; }
        /*
        public DbSet<Categoria> Categorias { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoriaMap());
           
        }*/

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
