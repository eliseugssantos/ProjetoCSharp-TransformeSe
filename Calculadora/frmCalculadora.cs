using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmCalculadora()
        {
            InitializeComponent();
        }
        public void limparcampos()
        {
         txtNumero1.Clear();
         txtNumero2.Clear();
         txtResultado.Clear();
         rdbSomar.Checked = false;
         rdbSubtrair.Checked = false;
         rdbMultiplicar.Checked = false;
         rdbDividir.Checked = false;
         txtNumero1.Focus();
        }
        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparcampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Declarando as variaveis
            double num1, num2, resp = 0;
            // inicializar a variaveis
            num1 = Convert.ToDouble(txtNumero1.Text);
            num2 = Convert.ToDouble(txtNumero2.Text);
            try
            {
                //Criando a estrutura de decisao
                if (rdbSomar.Checked == false && rdbSubtrair.Checked == false && rdbMultiplicar.Checked == false && rdbDividir.Checked)
                {
                    MessageBox.Show("Favor Seleciona uma operação", "Mensagem do sistema",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error,
                       MessageBoxDefaultButton.Button1);
                    limparcampos();
                }
                else
                {


                    if (rdbSomar.Checked)
                    {
                        //somando valores
                        resp = num1 + num2;
                    }
                    if (rdbSubtrair.Checked)
                    {
                        resp = num1 - num2;
                    }
                    if (rdbMultiplicar.Checked)
                    {
                        resp = num1 * num2;
                    }
                    if (rdbDividir.Checked)
                    {
                        if (num2 == 0)
                        {
                            MessageBox.Show("impossivel dividir por 0", "Mensaagem do sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                            limparcampos();
                        }
                        else
                        {

                            resp = num1 / num2;
                        }
                    }



                    txtResultado.Text = resp.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir valores validos", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparcampos();

            }
        }
    }
}
