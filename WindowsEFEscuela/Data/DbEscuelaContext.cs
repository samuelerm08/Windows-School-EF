using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Data
{
    public class DbEscuelaContext : DbContext
    {
        public DbEscuelaContext() : base("dbKey") { }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Aula> Aula { get; set; }
        public DbSet<Materia> Materia { get; set; }
    }
}
