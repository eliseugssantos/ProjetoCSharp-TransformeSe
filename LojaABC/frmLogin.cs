﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaABC
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Declarendo as variáveis do tipo string
            string usuario, senha;

            usuario = txtUsuario.Text;
            senha = txtSenha.Text;
            if (usuario.Equals("senac")&&senha.Equals("senac")) 
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha Invalido", "mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
               //Chamando o métudo limparCampos()
                limpandoCampos();
                
            }
        }
        //Limpando a janela
        public void limpandoCampos() 
        { 
         txtUsuario.Clear();
         txtSenha.Clear();
         txtUsuario.Focus();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
             btnEntrar.Focus();
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
