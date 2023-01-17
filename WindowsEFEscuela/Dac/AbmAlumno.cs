using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFEscuela.Data;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Dac
{
    public static class AbmAlumno
    {
        private readonly static DbEscuelaContext context = new DbEscuelaContext();

        public static List<Alumno> SelectAll()
        {
            return context.Alumnos.ToList();
        }

        public static Alumno SelectWhereById(int id)
        {
            return context.Alumnos.Find(id);            
        }
        
        public static int Insert(Alumno a)
        {
            context.Alumnos.Add(a);
            return context.SaveChanges();
        }

        public static int Update(Alumno a)
        {
            Alumno aa = context.Alumnos.Find(a.IdAlumno);
            aa.Nombre = a.Nombre;
            aa.Apellido = a.Apellido;
            aa.FechaNacimiento = a.FechaNacimiento;

            return context.SaveChanges();
        }

        public static int Delete(Alumno a)
        {
            Alumno aa = context.Alumnos.Find(a.IdAlumno);

            if (aa != null)
            {
                context.Alumnos.Remove(aa);
                return context.SaveChanges();
            }

            return 0;
        }
    }
}
