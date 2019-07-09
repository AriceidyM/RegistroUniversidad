using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Asignaturas> asignatura { get; set; }

        public DbSet<Estudiantes> estudiante { get; set; }
        public DbSet<Inscripciones> inscripcion { get; set; }

        public Contexto() : base("ConStr")
        { }
    }
}
