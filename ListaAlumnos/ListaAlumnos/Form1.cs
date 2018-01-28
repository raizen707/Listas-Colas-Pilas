using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaAlumnos
{
    public partial class Form1 : Form
    {
        List<Alumno> ListadoAlumnos = new List<Alumno>();
        Queue colaAlumno = new Queue();
        Stack pilaAlumno = new Stack();

        public Form1()
        {
            InitializeComponent();
            Alumno alumno1 = new Alumno();
            alumno1.Apellido = "Blanco";
            alumno1.Nombre = "Gomez";
            alumno1.Edad = 28;
            alumno1.Telefono = 45785464;

            Alumno alumno2 = new Alumno();
            alumno2.Apellido = "Gomez";
            alumno2.Nombre = "Steveen";
            alumno2.Edad = 24;
            alumno2.Telefono = 45785464;

            ListadoAlumnos.Add(alumno1);
            ListadoAlumnos.Add(alumno2);
            BindingSource bs = new BindingSource();
            bs.DataSource = ListadoAlumnos;
            dataGridView1.DataSource = bs;

            BindingSource bsNewCola = new BindingSource();
            colaAlumno.Enqueue(alumno1);
            colaAlumno.Enqueue(alumno2);
            bsNewCola.DataSource = colaAlumno;
            dataGridView2.DataSource = bsNewCola;

            BindingSource bsNewPila = new BindingSource();
            pilaAlumno.Push(alumno1);
            pilaAlumno.Push(alumno2);
            bsNewPila.DataSource = pilaAlumno;
            dataGridView3.DataSource = bsNewPila;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Alumno alumno3 = new Alumno();
            alumno3.Apellido = "Goku";
            alumno3.Nombre = "Mauricio";
            alumno3.Telefono = 2154865;
            alumno3.Edad = 26;
            BindingSource bs = new BindingSource();

            ListadoAlumnos.Add(alumno3);
            bs.ResetBindings(false);
            bs.DataSource = ListadoAlumnos;
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();

            colaAlumno.Enqueue(alumno3);
            BindingSource bsNewCola = new BindingSource();
            bsNewCola.ResetBindings(false);
            bsNewCola.DataSource = colaAlumno;
            dataGridView2.DataSource = bsNewCola;
            dataGridView2.Refresh();

            pilaAlumno.Push(alumno3);
            BindingSource bsNewPila = new BindingSource();
            bsNewCola.ResetBindings(false);
            bsNewPila.DataSource = pilaAlumno;
            dataGridView3.DataSource = bsNewPila;
            dataGridView2.Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ListadoAlumnos.RemoveAt(ListadoAlumnos.Count - 1);
            BindingSource bs = new BindingSource();
            bs.DataSource = ListadoAlumnos;
            bs.ResetBindings(false);
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();

            colaAlumno.Dequeue();
            BindingSource bsNewCola = new BindingSource();
            bsNewCola.ResetBindings(false);
            bsNewCola.DataSource = colaAlumno;
            dataGridView2.DataSource = bsNewCola;
            dataGridView2.Refresh();

            pilaAlumno.Pop();
            BindingSource bsNewPila = new BindingSource();
            bsNewCola.ResetBindings(false);
            bsNewPila.DataSource = pilaAlumno;
            dataGridView3.DataSource = bsNewPila;
            dataGridView2.Refresh();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
