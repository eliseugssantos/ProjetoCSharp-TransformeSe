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
            carregaCombo();
        }

        private void desbilitar()
        {
            txtImpostoDeRenda.Enabled = false;
            txtSalarioFolha.Enabled = false;
            txtSalarioLiquido.Enabled = false;
        }
        private void limparCampos() 
        {
            txtImpostoDeRenda.Clear();
            txtSalarioFolha.Clear();
            txtSalarioLiquido.Clear();
            txtSalario.Clear();
            ckbPlanoDeSaude.Checked = false;
            cbbClubeDeLazer.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
		public void carregaCombo()
		{
			cbbClubeDeLazer.Items.Add("Clube A - R$ 100,00");
			cbbClubeDeLazer.Items.Add("Clube B - R$ 50,00");
			cbbClubeDeLazer.Items.Add("Clube C - R$ 30,00");
		}

		private void txtSalario_TextChanged(object sender, EventArgs e)
		{
			txtSalarioFolha.Text = txtSalario.Text;
		}


		private void btnCalcular_Click(object sender, EventArgs e)
        {
			double salarioFolha = 0, impostoRenda = 0, salarioLiquido = 0;

            try 
            {
				salarioFolha = Convert.ToDouble(txtSalarioFolha.Text);

				if (salarioFolha < 2259.20)
				{
					salarioLiquido = 0;
					txtSalarioLiquido.Text = txtSalarioFolha.Text;
				}
				else if (salarioFolha >= 2259.21 && salarioFolha <= 2826.65)
				{
					impostoRenda = salarioFolha * 7.5 / 100;
					salarioLiquido = (salarioFolha - (impostoRenda));

				}
				else if (salarioFolha >= 2826.66 && salarioFolha <= 3751.05)
				{
					impostoRenda = salarioFolha * 15 / 100;
					salarioLiquido = (salarioFolha - (impostoRenda));

				}
				else if (salarioFolha >= 3751.06 && salarioFolha <= 4664.68)
				{
					impostoRenda = salarioFolha * 22.5 / 100;
					salarioLiquido = (salarioFolha - (impostoRenda));

				}
				else if (salarioFolha >= 4664.69)
				{
					impostoRenda = salarioFolha * 27.5 / 100;
					salarioLiquido = (salarioFolha - (impostoRenda));
				}

				if (ckbPlanoDeSaude.Checked)
				{
					salarioLiquido = salarioLiquido - 200;
				}
				if (cbbClubeDeLazer.SelectedIndex == 0)
				{
					salarioLiquido = salarioLiquido - 100;
				}
				if (cbbClubeDeLazer.SelectedIndex == 1)
				{
					salarioLiquido = salarioLiquido - 50;
				}
				if (cbbClubeDeLazer.SelectedIndex == 2)
				{
					salarioLiquido = salarioLiquido - 30;
				}

				txtImpostoDeRenda.Text = impostoRenda.ToString();
				txtSalarioLiquido.Text = salarioLiquido.ToString();

			}
			catch (Exception)
			{
				MessageBox.Show("Favor inserir salário válido",
					"Mensagem do sistema",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error,
					MessageBoxDefaultButton.Button1);
				limparCampos();
			}

		}

		private void frmFolhaDePagamento_Load(object sender, EventArgs e)
        {

        }

        
    }
}
