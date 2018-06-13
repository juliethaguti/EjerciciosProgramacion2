using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassEjercicio_68
{
    public partial class FormPersona : Form
    {
        private Persona persona;
        private event DelegadoString evento;

        public FormPersona()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (persona == null)
            {
                persona = new Persona(txtNombre.Text, txtApellido.Text);
                btnCrear.Text = "Actualizar";
                evento("La persona fue creada" + persona.Mostrar());
            }
            else
            {
                if (txtNombre.Text != persona.Nombre)
                {
                    persona.Nombre = txtNombre.Text;
                    evento("El nombre fue actualizado" + persona.Mostrar());
                }
                if (txtApellido.Text != persona.Apellido)
                {
                    persona.Apellido = txtApellido.Text;
                    evento("El apellido está actualizado" + persona.Mostrar());
                }
                evento(persona.Mostrar() + "La persona ha sido actulizada");
            }
        }
        
        public static void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje, "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormPersona_Load_1(object sender, EventArgs e)
        {
            evento += NotificarCambio;
        }

    }
}
