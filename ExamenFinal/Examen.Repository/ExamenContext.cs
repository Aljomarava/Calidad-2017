using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using Examen.Domain;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Examen.Repository
{
    public class ExamenContext : DbContext
    {
        public DbSet<Pregunta> Preguntas { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }
        public DbSet<Opcion> Opciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
