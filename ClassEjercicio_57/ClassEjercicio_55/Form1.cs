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

namespace ClassEjercicio_55
{
    public partial class Form1 : Form
    {
        string rutaDeArchivo = null;

        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Carateres";
            toolStripStatusLabel2.Text = "0";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaDeArchivo = openFileDialog1.FileName;
                StreamReader archivo = new StreamReader(rutaDeArchivo);
                richTextBox1.Text = archivo.ReadToEnd();
                archivo.Close();                
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaDeArchivo = saveFileDialog1.FileName;
                StreamWriter archivo = new StreamWriter(rutaDeArchivo);
                archivo.WriteLine(richTextBox1.Text);
                archivo.Close();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rutaDeArchivo != null)
            {
                StreamWriter archivo = new StreamWriter(rutaDeArchivo);
                archivo.WriteLine(richTextBox1.Text);
                archivo.Close();
            }
            else
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = String.Format("{0}",richTextBox1.Text.Length);
        }  
    }
}
