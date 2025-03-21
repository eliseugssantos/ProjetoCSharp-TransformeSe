using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }
        public void limparcapos()
        {
         txtNumero1.Clear();
         txtNumero2.Clear();
         txtResultado.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparcapos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbSomar_CheckedChanged(object sender, EventArgs e)
        {
            int n1 = 

        }
    }
}
