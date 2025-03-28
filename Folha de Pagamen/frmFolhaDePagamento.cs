using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_de_Pagamen
{
    public partial class frmFolhaDePagamento : Form
    {
        public frmFolhaDePagamento()
        {
            InitializeComponent();
            desbilitar();
        }

        private void desbilitar()
        {
            txtImpostoDeRenda.Enabled = false;
            txtSalarioFolha.Enabled = false;
            txtSalárioLiquido.Enabled = false;
        }
        private void limparCampos() 
        {
            txtImpostoDeRenda.Clear();
            txtSalarioFolha.Clear();
            txtSalárioLiquido.Clear();
            txtSalario.Clear();
            ckbPlanoDeSaude.Checked = false;
            cbbClubeDeazer.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario,salarioFolha, salarioliquido = 0, impostoderenda;

            salarioFolha = Convert.ToDouble(txtSalarioFolha);
            salario = Convert.ToDouble(txtSalario);
            salarioFolha = salario;

             
        }
    }
}
