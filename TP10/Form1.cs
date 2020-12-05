using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP10
{
    public partial class Form1 : Form
    {
        GestorAlumno gestorAlumnos;
        GestorNota gestorNotas;
        GestorPromedio gestorPromedio;
        public Form1()
        {
            InitializeComponent();

            gestorAlumnos = new GestorAlumno();
            gestorNotas = new GestorNota();
            gestorPromedio = new GestorPromedio();
            MostrarAlumnos();
            MostrarNotas();
            MostrarPromedio();
        }
        public Boolean comprobarDatos(int txt)
        {
            FileStream fs = new FileStream("C:\\Users\\Usuario\\Desktop\\Alumnos.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            String[] VectorRegAux = new String[0];
            string reg = "";
            int DNI;
            while (sr.Peek() > -1)
            {
                reg = sr.ReadLine();
                VectorRegAux = reg.Split(',');
                DNI = Convert.ToInt32(VectorRegAux[0]);
                if (DNI == txt)
                {
                    fs.Close();
                    return false;
                }
            }
            fs.Close();
            return true;
        }
        public Boolean ingresoCorrecto()
        {
            if (txtDNI.Value == 0 || txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
        void MostrarAlumnos()
        {
            this.gridAlumno.DataSource = null;
            this.gridAlumno.DataSource = gestorAlumnos.LeerAlumno();
            txtDNI.Value = 0;
            txtNombre.Text = null;
            txtApellido.Text = null;
        }
        void MostrarNotas()
        {
            this.gridNota.DataSource = null;
            this.gridNota.DataSource = gestorNotas.LeerNotas();
        }
        void MostrarPromedio()
        {
            this.gridPromedio.DataSource = null;
            this.gridPromedio.DataSource = gestorPromedio.LeerPromedio();
        }
        private void btnAlumnoGuardar_Click(object sender, EventArgs e)
        {
            if (comprobarDatos(Convert.ToInt32(this.txtDNI.Value)) && ingresoCorrecto())
            {
                Alumno unAlumno = new Alumno((long)this.txtDNI.Value, this.txtNombre.Text, this.txtApellido.Text);
                gestorAlumnos.GuardarALumno(unAlumno);
                MostrarAlumnos();
                txtDNI.Value = 0;
                txtNombre.Text = null;
                txtApellido.Text = null;
            }
            else MessageBox.Show("El alumno ya esta registrado o el formulario esta imcompleto");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNotaGuardar_Click(object sender, EventArgs e)
        {
            if (!comprobarDatos(Convert.ToInt32(this.txtDNIdisponibles.Value)))
            {
                Nota unaNota = new Nota((long)this.txtDNIdisponibles.Value, (int)this.txtNote.Value, this.txtDay.Text);
                gestorNotas.GuardarNota(unaNota);
                MostrarNotas();
            }
            else MessageBox.Show("Alumno no registrado");
        }

        private void btnOrdenarAlumnos_Click(object sender, EventArgs e)
        {
            this.gridAlumno.DataSource = null;
            this.gridAlumno.DataSource = gestorAlumnos.SubirOrdenar();
        }

        private void btnOrdenarNotas_Click(object sender, EventArgs e)
        {
            this.gridNota.DataSource = null;
            this.gridNota.DataSource = gestorNotas.SubirOrdenar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Queres borrar todos los datos?", "Eliminar", botones);

            if (dr == DialogResult.Yes)
            {
                File.Delete("C:\\Users\\Usuario\\Desktop\\Nota.txt");
                File.Delete("C:\\Users\\Usuario\\Desktop\\Alumnos.txt");
                File.Delete("C:\\Users\\Usuario\\Desktop\\promedio.txt");
                MostrarAlumnos();
                MostrarNotas();
                MostrarPromedio();
            }
        }

        private void btnPromediar_Click(object sender, EventArgs e)
        {

            gestorPromedio.Promedios();
            MostrarPromedio();
        }
    }
}
