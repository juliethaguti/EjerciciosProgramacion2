using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralHerencia;

namespace FrmCentral
{
    public partial class FrmLlamada : Form
    {
        public Llamada nuevaLlamada;
        public FrmLlamada()
        {
            InitializeComponent();
            //this.cmbTipoLlamada.DataSource = Enum.GetValues(typeof(Llamada.TipoLlamada));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float duracion;
            float.TryParse(txtDuracion.Text, out duracion);
            string tipo = cmbTipoLlamada.Text;

            switch (cmbTipoLlamada.SelectedIndex)
            {
                case 0:
                    this.nuevaLlamada = new Local(txtOrigen.Text, duracion, txtDestino.Text, 0.5f);
                    break;
                case 1:
                    this.nuevaLlamada = new Provincial(txtOrigen.Text, Provincial.Franja.Franja_2, duracion, txtDestino.Text);
                    break;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
