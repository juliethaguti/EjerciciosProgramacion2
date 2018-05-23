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
using FrmCentral;

namespace FrmCentral
{
    public partial class FrmCentralita : Form
    {
        public Centralita central;
        public FrmCentralita()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmLlamada llamada = new FrmLlamada();
  
            if (llamada.ShowDialog() == DialogResult.OK)
            {
                central += llamada.nuevaLlamada;
                
            }
        }

        private void FrmCentralita_Load(object sender, EventArgs e)
        {
            this.central = new Centralita(txtRazonSocial.Text);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Llamada l in this.central.Llamadas)
            {
                listBox1.Items.Add(l);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "Local")
            {
                lblGanancias.Text = central.GananciasPorLocal.ToString();
            }
            else if (cmbTipo.Text == "Provincial")
            {
                lblGanancias.Text = central.GananciasPorProvincial.ToString();
            }
            else
            {
                lblGanancias.Text = central.GananciasPorTotal.ToString();
            }
        }
    }
}
