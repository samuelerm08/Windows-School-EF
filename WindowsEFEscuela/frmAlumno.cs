using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFEscuela.Dac;
using WindowsEFEscuela.Data;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela
{
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        private readonly DbEscuelaContext escuelaContext = new DbEscuelaContext();
        private Profesor p = new Profesor();        
        private void Insertar(object sender, EventArgs e)
        {                        
            foreach (var item in escuelaContext.Profesores)
            {
                p = item;
            }

            comboProfe.Tag = p;

            var a = new Alumno()
            {
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                FechaNacimiento = Convert.ToDateTime(dtFecha.Text),
                ProfesorId = p.ProfesorId
            };            

            int rAffected = AbmAlumno.Insert(a);

            if (rAffected > 0)
            {
                MessageBox.Show("Insert exitoso");
                MostrarTodos();
            }
        }

        private void Modificar(object sender, EventArgs e)
        {
            foreach (var item in escuelaContext.Profesores)
            {
                p = item;
            }

            comboProfe.Tag = p;

            var a = new Alumno()
            {
                IdAlumno = int.Parse(tbID.Text),
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                FechaNacimiento = Convert.ToDateTime(dtFecha.Value),  
                ProfesorId = p.ProfesorId
            };                        

            int rAffected = AbmAlumno.Update(a);

            if (rAffected > 0)
            {
                MessageBox.Show("Update exitoso");
                MostrarTodos();
            }
        }

        private void VerTodos(object sender, EventArgs e)
        {
            dataGrid.DataSource = AbmAlumno.SelectAll();
        }

        private void VerUno(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(tbID.Text);
            Alumno a = AbmAlumno.SelectWhereById(id);

            MessageBox.Show("Alumno: \n" + a.Nombre);
        }

        private void Eliminar(object sender, EventArgs e)
        {
            var a = new Alumno()
            {
                IdAlumno = int.Parse(tbID.Text),
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                FechaNacimiento = Convert.ToDateTime(dtFecha.Value),
                ProfesorId = Convert.ToInt16(comboProfe.SelectedItem)
            };

            int rAffected = AbmAlumno.Delete(a);

            if (rAffected > 0)
            {
                MessageBox.Show("Eliminado con exito");
                MostrarTodos();
            }
        }
        private void MostrarTodos()
        {
            dataGrid.DataSource = AbmAlumno.SelectAll();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {                        
            foreach (var item in escuelaContext.Profesores)
            {
                comboProfe.Items.Add(item.Nombre);
            }
        }
    }
}
