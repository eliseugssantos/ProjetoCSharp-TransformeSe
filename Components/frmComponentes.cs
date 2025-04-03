﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components
{
    public partial class frmComponentes : Form
    {
        public frmComponentes()
        {
            InitializeComponent();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
           
            
            if (e.KeyCode == Keys.Enter) 
            {
             cbbListaNome.Items.Add(txtNome.Text);
                txtNome.Clear();
                txtNome.Focus();
            }
        }

        private void ckbLivros_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLivros.Checked)
            {
                ltbListarProdutos.Items.Add("Livros");
                pcbImagens.Load(@".\imagens\Livro.png");
            }
            else
            {
                ltbListarProdutos.Items.Remove("Livros");
            }
        }

        private void ckbComputador_CheckedChanged(object sender, EventArgs e)
        {

            if (ckbComputador.Checked)
            {
                ltbListarProdutos.Items.Add("Computador");
                pcbImagens.Load(@".\imagens\computador.png");
            }
            else 
            {
                ltbListarProdutos.Items.Remove("Computador");
            }
        }

        private void ckbMesa_CheckedChanged(object sender, EventArgs e)
        {

            if (ckbMesa.Checked)
            {
                ltbListarProdutos.Items.Add("Mesa");
                pcbImagens.Load(@".\imagens\mesa.png");
            }
            else
            {
                ltbListarProdutos.Items.Remove("Mesa");
            }
        }

        private void ckbBanana_CheckedChanged(object sender, EventArgs e)
        {

            if (ckbBanana.Checked)
            {
                ltbListarProdutos.Items.Add("Banana");
                pcbImagens.Load(@".\imagens\banana.png");
            }
            else 
            {
                ltbListarProdutos.Items.Remove("Banana");
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "selelcione um imagem";
            ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp|Todos os arquivos|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcbImagens.ImageLocation = ofd.FileName;
                pcbImagens.Load();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pcbImagens.Image = null;
        }
    }
}
