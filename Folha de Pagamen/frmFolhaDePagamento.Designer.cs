namespace Folha_de_Pagamen
{
    partial class frmFolhaDePagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaDePagamento));
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtImpostoDeRenda = new System.Windows.Forms.TextBox();
            this.txtSalarioFolha = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dtpDataFolha = new System.Windows.Forms.DateTimePicker();
            this.ckbPlanoDeSaude = new System.Windows.Forms.CheckBox();
            this.cbbClubeDeLazer = new System.Windows.Forms.ComboBox();
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblClubeDelazer = new System.Windows.Forms.Label();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.lblImpostoDeRenda = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(33, 127);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(163, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(565, 237);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(147, 20);
            this.txtSalarioLiquido.TabIndex = 2;
            // 
            // txtImpostoDeRenda
            // 
            this.txtImpostoDeRenda.Location = new System.Drawing.Point(565, 162);
            this.txtImpostoDeRenda.Name = "txtImpostoDeRenda";
            this.txtImpostoDeRenda.Size = new System.Drawing.Size(147, 20);
            this.txtImpostoDeRenda.TabIndex = 3;
            // 
            // txtSalarioFolha
            // 
            this.txtSalarioFolha.Location = new System.Drawing.Point(565, 78);
            this.txtSalarioFolha.Name = "txtSalarioFolha";
            this.txtSalarioFolha.Size = new System.Drawing.Size(147, 20);
            this.txtSalarioFolha.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalcular.Location = new System.Drawing.Point(367, 348);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 45);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(507, 348);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 45);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(650, 348);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 46);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dtpDataFolha
            // 
            this.dtpDataFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFolha.Location = new System.Drawing.Point(38, 54);
            this.dtpDataFolha.Name = "dtpDataFolha";
            this.dtpDataFolha.Size = new System.Drawing.Size(158, 26);
            this.dtpDataFolha.TabIndex = 8;
            this.dtpDataFolha.Value = new System.DateTime(2025, 3, 28, 14, 22, 2, 0);
            // 
            // ckbPlanoDeSaude
            // 
            this.ckbPlanoDeSaude.AutoSize = true;
            this.ckbPlanoDeSaude.Location = new System.Drawing.Point(38, 153);
            this.ckbPlanoDeSaude.Name = "ckbPlanoDeSaude";
            this.ckbPlanoDeSaude.Size = new System.Drawing.Size(100, 17);
            this.ckbPlanoDeSaude.TabIndex = 9;
            this.ckbPlanoDeSaude.Text = "Plano de saúde";
            this.ckbPlanoDeSaude.UseVisualStyleBackColor = true;
            // 
            // cbbClubeDeLazer
            // 
            this.cbbClubeDeLazer.FormattingEnabled = true;
            this.cbbClubeDeLazer.Location = new System.Drawing.Point(38, 236);
            this.cbbClubeDeLazer.Name = "cbbClubeDeLazer";
            this.cbbClubeDeLazer.Size = new System.Drawing.Size(127, 21);
            this.cbbClubeDeLazer.TabIndex = 10;
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFolha.Location = new System.Drawing.Point(34, 31);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(88, 20);
            this.lblDataFolha.TabIndex = 11;
            this.lblDataFolha.Text = "Data Folha";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(34, 104);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(58, 20);
            this.lblSalario.TabIndex = 12;
            this.lblSalario.Text = "Salário";
            // 
            // lblClubeDelazer
            // 
            this.lblClubeDelazer.AutoSize = true;
            this.lblClubeDelazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubeDelazer.Location = new System.Drawing.Point(34, 213);
            this.lblClubeDelazer.Name = "lblClubeDelazer";
            this.lblClubeDelazer.Size = new System.Drawing.Size(110, 20);
            this.lblClubeDelazer.TabIndex = 13;
            this.lblClubeDelazer.Text = "Clube de lazer";
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFolha.Location = new System.Drawing.Point(444, 78);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(102, 20);
            this.lblSalarioFolha.TabIndex = 14;
            this.lblSalarioFolha.Text = "Salário Folha";
            // 
            // lblImpostoDeRenda
            // 
            this.lblImpostoDeRenda.AutoSize = true;
            this.lblImpostoDeRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpostoDeRenda.Location = new System.Drawing.Point(405, 162);
            this.lblImpostoDeRenda.Name = "lblImpostoDeRenda";
            this.lblImpostoDeRenda.Size = new System.Drawing.Size(141, 20);
            this.lblImpostoDeRenda.TabIndex = 15;
            this.lblImpostoDeRenda.Text = "Imposto de Renda";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(433, 237);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(113, 20);
            this.lblSalarioLiquido.TabIndex = 16;
            this.lblSalarioLiquido.Text = "Salário Liquido";
            // 
            // frmFolhaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblImpostoDeRenda);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.lblClubeDelazer);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblDataFolha);
            this.Controls.Add(this.cbbClubeDeLazer);
            this.Controls.Add(this.ckbPlanoDeSaude);
            this.Controls.Add(this.dtpDataFolha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalarioFolha);
            this.Controls.Add(this.txtImpostoDeRenda);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFolhaDePagamento";
            this.Text = "frmFolhaDePagamento";
            this.Load += new System.EventHandler(this.frmFolhaDePagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtImpostoDeRenda;
        private System.Windows.Forms.TextBox txtSalarioFolha;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DateTimePicker dtpDataFolha;
        private System.Windows.Forms.CheckBox ckbPlanoDeSaude;
        private System.Windows.Forms.ComboBox cbbClubeDeLazer;
        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblClubeDelazer;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Label lblImpostoDeRenda;
        private System.Windows.Forms.Label lblSalarioLiquido;
    }
}