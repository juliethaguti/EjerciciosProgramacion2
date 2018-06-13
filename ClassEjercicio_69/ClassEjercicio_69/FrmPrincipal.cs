using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassEjercicio_69
{
    public partial class FrmPrincipal : Form
    {
        frmTestDelegados formTestDelegados;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTestDelegados = new frmTestDelegados();
            formTestDelegados.Owner = this;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

        }
    }
}
