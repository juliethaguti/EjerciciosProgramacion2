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
    public partial class FrmPickup : Form
    {
        PickUp p;
        public FrmPickup()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            p = new PickUp(txtPatente.Text,txtModelo.Text);

            MessageBox.Show(p.ConsultarDatos(), "Nueva PickUp", MessageBoxButtons.OK);
        }
    }
}
