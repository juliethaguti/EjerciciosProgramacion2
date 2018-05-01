using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace ClassEjercicio_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            estadoInicial();

        }

        private void estadoInicial()
        {
            txtEuro.Focus();
            txtEuroADolar.Enabled = false;
            txtEuroAEuro.Enabled = false;
            txtEuroAPesos.Enabled = false;
            txtDolarAPesos.Enabled = false;
            txtDolarAEuro.Enabled = false;
            txtDolarADolar.Enabled = false;
            txtPesosADolar.Enabled = false;
            txtPesosAEuros.Enabled = false;
            txtPesosAPesos.Enabled = false;
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double eu;
            double.TryParse(txtEuro.Text,out eu);
            Euro euro = new Euro(eu);
            txtEuroAEuro.Text = euro.Cantidad.ToString();

            Pesos eurosAPesos = (Pesos)euro;
             txtEuroAPesos.Text = eurosAPesos.Cantidad.ToString();

             Dolar eurosAdolares = (Dolar)euro;
             txtEuroADolar.Text = eurosAdolares.Cantidad.ToString();
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double d;
            double.TryParse(txtDolar.Text,out d);
            Dolar dolar = new Dolar(d);
            txtDolarADolar.Text = dolar.Cantidad.ToString();

            Euro euro = (Euro) dolar;
            txtDolarAEuro.Text = euro.Cantidad.ToString();

            Pesos pesos = (Pesos) dolar;
            txtDolarAPesos.Text = pesos.Cantidad.ToString();
        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            double p;
            double.TryParse(txtPesos.Text, out p);
            Pesos pesos = new Pesos(p);
            txtPesosAPesos.Text = pesos.Cantidad.ToString();

            Euro euro = (Euro)pesos;
            txtPesosAEuros.Text = euro.Cantidad.ToString();

            Dolar dolares = (Dolar)pesos;
            txtPesosADolar.Text = dolares.Cantidad.ToString();
        }
    }
}
