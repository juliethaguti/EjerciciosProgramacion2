using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class Form1 : Form
    {
        Curso curso;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            short anio;
            short.TryParse(nudAnioCurso.Value.ToString(), out anio);
            Divisiones division;
            if (String.IsNullOrEmpty(txtNombreProfe.Text) && String.IsNullOrEmpty(txtApellidoProfe.Text)
                && String.IsNullOrEmpty(txtDocumentoProfe.Text))
            {
                MessageBox.Show("Complete todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Profesor profesor = new Profesor(txtNombreProfe.Text, txtApellidoProfe.Text, txtDocumentoProfe.Text,dtpFechaIngreso.Value);
                Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
                curso = new Curso(anio, division, profesor);
            }           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Divisiones division;
            short anio;
            if (String.IsNullOrEmpty(txtNombre.Text) && String.IsNullOrEmpty(txtApellido.Text) &&
                String.IsNullOrEmpty(txtDocumento.Text))
            {
                MessageBox.Show("Complete todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                short.TryParse(nudAnio.Value.ToString(), out anio);
                Enum.TryParse<Divisiones>(cmbDivision.SelectedValue.ToString(), out division);
                Alumno alumno = new Alumno(txtNombre.Text, txtApellido.Text, txtDocumento.Text,
                    anio,division);
                curso += alumno;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            rtbDatos.Text = (string)curso;
        }
    }
}
