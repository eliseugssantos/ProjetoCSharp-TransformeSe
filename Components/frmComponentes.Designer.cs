namespace Components
{
    partial class frmComponentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponentes));
            this.gpbComponentes = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblListarProdutos = new System.Windows.Forms.Label();
            this.lblListaNome = new System.Windows.Forms.Label();
            this.ltbListarProdutos = new System.Windows.Forms.ListBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.ckbLivros = new System.Windows.Forms.CheckBox();
            this.ckbComputador = new System.Windows.Forms.CheckBox();
            this.ckbMesa = new System.Windows.Forms.CheckBox();
            this.ckbBanana = new System.Windows.Forms.CheckBox();
            this.cbbListaNome = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbComponentes
            // 
            this.gpbComponentes.Controls.Add(this.pictureBox1);
            this.gpbComponentes.Controls.Add(this.cbbListaNome);
            this.gpbComponentes.Controls.Add(this.ckbBanana);
            this.gpbComponentes.Controls.Add(this.ckbMesa);
            this.gpbComponentes.Controls.Add(this.ckbComputador);
            this.gpbComponentes.Controls.Add(this.ckbLivros);
            this.gpbComponentes.Controls.Add(this.lblEscolha);
            this.gpbComponentes.Controls.Add(this.txtNome);
            this.gpbComponentes.Controls.Add(this.ltbListarProdutos);
            this.gpbComponentes.Controls.Add(this.lblListaNome);
            this.gpbComponentes.Controls.Add(this.lblListarProdutos);
            this.gpbComponentes.Controls.Add(this.lblNome);
            this.gpbComponentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbComponentes.Location = new System.Drawing.Point(12, 12);
            this.gpbComponentes.Name = "gpbComponentes";
            this.gpbComponentes.Size = new System.Drawing.Size(750, 532);
            this.gpbComponentes.TabIndex = 0;
            this.gpbComponentes.TabStop = false;
            this.gpbComponentes.Text = "Componentes";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(21, 80);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblListarProdutos
            // 
            this.lblListarProdutos.AutoSize = true;
            this.lblListarProdutos.Location = new System.Drawing.Point(354, 71);
            this.lblListarProdutos.Name = "lblListarProdutos";
            this.lblListarProdutos.Size = new System.Drawing.Size(116, 20);
            this.lblListarProdutos.TabIndex = 1;
            this.lblListarProdutos.Text = "Listar Produtos";
            // 
            // lblListaNome
            // 
            this.lblListaNome.AutoSize = true;
            this.lblListaNome.Location = new System.Drawing.Point(24, 262);
            this.lblListaNome.Name = "lblListaNome";
            this.lblListaNome.Size = new System.Drawing.Size(81, 20);
            this.lblListaNome.TabIndex = 2;
            this.lblListaNome.Text = "lista nome";
            // 
            // ltbListarProdutos
            // 
            this.ltbListarProdutos.FormattingEnabled = true;
            this.ltbListarProdutos.ItemHeight = 20;
            this.ltbListarProdutos.Location = new System.Drawing.Point(358, 111);
            this.ltbListarProdutos.Name = "ltbListarProdutos";
            this.ltbListarProdutos.Size = new System.Drawing.Size(351, 164);
            this.ltbListarProdutos.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 123);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(21, 329);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(66, 20);
            this.lblEscolha.TabIndex = 6;
            this.lblEscolha.Text = "Escolha";
            // 
            // ckbLivros
            // 
            this.ckbLivros.AutoSize = true;
            this.ckbLivros.Location = new System.Drawing.Point(25, 367);
            this.ckbLivros.Name = "ckbLivros";
            this.ckbLivros.Size = new System.Drawing.Size(69, 24);
            this.ckbLivros.TabIndex = 3;
            this.ckbLivros.Text = "Livros";
            this.ckbLivros.UseVisualStyleBackColor = true;
            this.ckbLivros.CheckedChanged += new System.EventHandler(this.ckbLivros_CheckedChanged);
            // 
            // ckbComputador
            // 
            this.ckbComputador.AutoSize = true;
            this.ckbComputador.Location = new System.Drawing.Point(25, 397);
            this.ckbComputador.Name = "ckbComputador";
            this.ckbComputador.Size = new System.Drawing.Size(116, 24);
            this.ckbComputador.TabIndex = 4;
            this.ckbComputador.Text = "Computador";
            this.ckbComputador.UseVisualStyleBackColor = true;
            this.ckbComputador.CheckedChanged += new System.EventHandler(this.ckbComputador_CheckedChanged);
            // 
            // ckbMesa
            // 
            this.ckbMesa.AutoSize = true;
            this.ckbMesa.Location = new System.Drawing.Point(25, 427);
            this.ckbMesa.Name = "ckbMesa";
            this.ckbMesa.Size = new System.Drawing.Size(67, 24);
            this.ckbMesa.TabIndex = 5;
            this.ckbMesa.Text = "Mesa";
            this.ckbMesa.UseVisualStyleBackColor = true;
            this.ckbMesa.CheckedChanged += new System.EventHandler(this.ckbMesa_CheckedChanged);
            // 
            // ckbBanana
            // 
            this.ckbBanana.AutoSize = true;
            this.ckbBanana.Location = new System.Drawing.Point(28, 457);
            this.ckbBanana.Name = "ckbBanana";
            this.ckbBanana.Size = new System.Drawing.Size(84, 24);
            this.ckbBanana.TabIndex = 6;
            this.ckbBanana.Text = "Banana";
            this.ckbBanana.UseVisualStyleBackColor = true;
            this.ckbBanana.CheckedChanged += new System.EventHandler(this.ckbBanana_CheckedChanged);
            // 
            // cbbListaNome
            // 
            this.cbbListaNome.FormattingEnabled = true;
            this.cbbListaNome.Location = new System.Drawing.Point(16, 285);
            this.cbbListaNome.Name = "cbbListaNome";
            this.cbbListaNome.Size = new System.Drawing.Size(230, 28);
            this.cbbListaNome.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(358, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 196);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbComponentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.gpbComponentes.ResumeLayout(false);
            this.gpbComponentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbComponentes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox ltbListarProdutos;
        private System.Windows.Forms.Label lblListaNome;
        private System.Windows.Forms.Label lblListarProdutos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.CheckBox ckbBanana;
        private System.Windows.Forms.CheckBox ckbMesa;
        private System.Windows.Forms.CheckBox ckbComputador;
        private System.Windows.Forms.CheckBox ckbLivros;
        private System.Windows.Forms.ComboBox cbbListaNome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}