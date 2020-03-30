namespace Salario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblNumeroFilhos = new System.Windows.Forms.Label();
            this.mskbxNomeFunc = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.mskbxNumeroFilhos = new System.Windows.Forms.MaskedTextBox();
            this.btnVerificaDesconto = new System.Windows.Forms.Button();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblAliqINSS = new System.Windows.Forms.Label();
            this.lblAliqIRPF = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.mskbxAliqINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliqIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalarioFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalarioLiquido = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFunc.Location = new System.Drawing.Point(27, 61);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(144, 16);
            this.lblNomeFunc.TabIndex = 0;
            this.lblNomeFunc.Text = "Nome funcionário:";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(27, 95);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(120, 16);
            this.lblSalarioBruto.TabIndex = 1;
            this.lblSalarioBruto.Text = "Salário bruto:";
            // 
            // lblNumeroFilhos
            // 
            this.lblNumeroFilhos.AutoSize = true;
            this.lblNumeroFilhos.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFilhos.Location = new System.Drawing.Point(27, 129);
            this.lblNumeroFilhos.Name = "lblNumeroFilhos";
            this.lblNumeroFilhos.Size = new System.Drawing.Size(144, 16);
            this.lblNumeroFilhos.TabIndex = 2;
            this.lblNumeroFilhos.Text = "Número de filhos:";
            // 
            // mskbxNomeFunc
            // 
            this.mskbxNomeFunc.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxNomeFunc.Location = new System.Drawing.Point(178, 57);
            this.mskbxNomeFunc.Mask = "??????????????????????????????????????????????????????????????????????";
            this.mskbxNomeFunc.Name = "mskbxNomeFunc";
            this.mskbxNomeFunc.Size = new System.Drawing.Size(201, 22);
            this.mskbxNomeFunc.TabIndex = 3;
            // 
            // mskbxSalarioBruto
            // 
            this.mskbxSalarioBruto.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalarioBruto.Location = new System.Drawing.Point(178, 91);
            this.mskbxSalarioBruto.Mask = "$999999.00";
            this.mskbxSalarioBruto.Name = "mskbxSalarioBruto";
            this.mskbxSalarioBruto.Size = new System.Drawing.Size(112, 22);
            this.mskbxSalarioBruto.TabIndex = 4;
            // 
            // mskbxNumeroFilhos
            // 
            this.mskbxNumeroFilhos.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxNumeroFilhos.Location = new System.Drawing.Point(178, 125);
            this.mskbxNumeroFilhos.Mask = "99";
            this.mskbxNumeroFilhos.Name = "mskbxNumeroFilhos";
            this.mskbxNumeroFilhos.Size = new System.Drawing.Size(26, 22);
            this.mskbxNumeroFilhos.TabIndex = 5;
            // 
            // btnVerificaDesconto
            // 
            this.btnVerificaDesconto.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificaDesconto.Location = new System.Drawing.Point(129, 211);
            this.btnVerificaDesconto.Name = "btnVerificaDesconto";
            this.btnVerificaDesconto.Size = new System.Drawing.Size(377, 30);
            this.btnVerificaDesconto.TabIndex = 6;
            this.btnVerificaDesconto.Text = "Verifica Desconto";
            this.btnVerificaDesconto.UseVisualStyleBackColor = true;
            this.btnVerificaDesconto.Click += new System.EventHandler(this.btnVerificaDesconto_Click);
            // 
            // lblDados
            // 
            this.lblDados.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.Location = new System.Drawing.Point(27, 270);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(379, 55);
            this.lblDados.TabIndex = 7;
            // 
            // lblAliqINSS
            // 
            this.lblAliqINSS.AutoSize = true;
            this.lblAliqINSS.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliqINSS.Location = new System.Drawing.Point(27, 349);
            this.lblAliqINSS.Name = "lblAliqINSS";
            this.lblAliqINSS.Size = new System.Drawing.Size(120, 16);
            this.lblAliqINSS.TabIndex = 8;
            this.lblAliqINSS.Text = "Alíquota INSS:";
            // 
            // lblAliqIRPF
            // 
            this.lblAliqIRPF.AutoSize = true;
            this.lblAliqIRPF.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliqIRPF.Location = new System.Drawing.Point(27, 393);
            this.lblAliqIRPF.Name = "lblAliqIRPF";
            this.lblAliqIRPF.Size = new System.Drawing.Size(120, 16);
            this.lblAliqIRPF.TabIndex = 9;
            this.lblAliqIRPF.Text = "Alíquota IRPF:";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFamilia.Location = new System.Drawing.Point(27, 437);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(136, 16);
            this.lblSalarioFamilia.TabIndex = 10;
            this.lblSalarioFamilia.Text = "Salário Família:";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(27, 481);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(136, 16);
            this.lblSalarioLiquido.TabIndex = 11;
            this.lblSalarioLiquido.Text = "Salário Líquido:";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescINSS.Location = new System.Drawing.Point(325, 349);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(120, 16);
            this.lblDescINSS.TabIndex = 12;
            this.lblDescINSS.Text = "Desconto INSS:";
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescIRPF.Location = new System.Drawing.Point(325, 393);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(120, 16);
            this.lblDescIRPF.TabIndex = 13;
            this.lblDescIRPF.Text = "Desconto IRPF:";
            // 
            // mskbxAliqINSS
            // 
            this.mskbxAliqINSS.Enabled = false;
            this.mskbxAliqINSS.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxAliqINSS.Location = new System.Drawing.Point(177, 345);
            this.mskbxAliqINSS.Name = "mskbxAliqINSS";
            this.mskbxAliqINSS.Size = new System.Drawing.Size(113, 22);
            this.mskbxAliqINSS.TabIndex = 14;
            // 
            // mskbxAliqIRPF
            // 
            this.mskbxAliqIRPF.Enabled = false;
            this.mskbxAliqIRPF.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxAliqIRPF.Location = new System.Drawing.Point(177, 391);
            this.mskbxAliqIRPF.Name = "mskbxAliqIRPF";
            this.mskbxAliqIRPF.Size = new System.Drawing.Size(113, 22);
            this.mskbxAliqIRPF.TabIndex = 15;
            // 
            // mskbxSalarioFamilia
            // 
            this.mskbxSalarioFamilia.Enabled = false;
            this.mskbxSalarioFamilia.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalarioFamilia.Location = new System.Drawing.Point(177, 433);
            this.mskbxSalarioFamilia.Name = "mskbxSalarioFamilia";
            this.mskbxSalarioFamilia.Size = new System.Drawing.Size(113, 22);
            this.mskbxSalarioFamilia.TabIndex = 16;
            // 
            // mskbxSalarioLiquido
            // 
            this.mskbxSalarioLiquido.Enabled = false;
            this.mskbxSalarioLiquido.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalarioLiquido.Location = new System.Drawing.Point(177, 477);
            this.mskbxSalarioLiquido.Name = "mskbxSalarioLiquido";
            this.mskbxSalarioLiquido.Size = new System.Drawing.Size(113, 22);
            this.mskbxSalarioLiquido.TabIndex = 17;
            // 
            // mskbxDescINSS
            // 
            this.mskbxDescINSS.Enabled = false;
            this.mskbxDescINSS.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxDescINSS.Location = new System.Drawing.Point(465, 345);
            this.mskbxDescINSS.Name = "mskbxDescINSS";
            this.mskbxDescINSS.Size = new System.Drawing.Size(113, 22);
            this.mskbxDescINSS.TabIndex = 18;
            // 
            // mskbxDescIRPF
            // 
            this.mskbxDescIRPF.Enabled = false;
            this.mskbxDescIRPF.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxDescIRPF.Location = new System.Drawing.Point(465, 391);
            this.mskbxDescIRPF.Name = "mskbxDescIRPF";
            this.mskbxDescIRPF.Size = new System.Drawing.Size(113, 22);
            this.mskbxDescIRPF.TabIndex = 19;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnFeminino);
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.Location = new System.Drawing.Point(446, 46);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(132, 79);
            this.gbxSexo.TabIndex = 20;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Checked = true;
            this.rbtnMasculino.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.Location = new System.Drawing.Point(19, 25);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(34, 20);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "M";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFeminino.Location = new System.Drawing.Point(19, 46);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(34, 20);
            this.rbtnFeminino.TabIndex = 1;
            this.rbtnFeminino.Text = "F";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxCasado.Location = new System.Drawing.Point(446, 131);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(75, 20);
            this.ckbxCasado.TabIndex = 21;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 591);
            this.Controls.Add(this.ckbxCasado);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.mskbxDescIRPF);
            this.Controls.Add(this.mskbxDescINSS);
            this.Controls.Add(this.mskbxSalarioLiquido);
            this.Controls.Add(this.mskbxSalarioFamilia);
            this.Controls.Add(this.mskbxAliqIRPF);
            this.Controls.Add(this.mskbxAliqINSS);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblAliqIRPF);
            this.Controls.Add(this.lblAliqINSS);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.btnVerificaDesconto);
            this.Controls.Add(this.mskbxNumeroFilhos);
            this.Controls.Add(this.mskbxSalarioBruto);
            this.Controls.Add(this.mskbxNomeFunc);
            this.Controls.Add(this.lblNumeroFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNomeFunc);
            this.Name = "Form1";
            this.Text = "Cálculo Salário";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblNumeroFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxNomeFunc;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioBruto;
        private System.Windows.Forms.MaskedTextBox mskbxNumeroFilhos;
        private System.Windows.Forms.Button btnVerificaDesconto;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblAliqINSS;
        private System.Windows.Forms.Label lblAliqIRPF;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxAliqINSS;
        private System.Windows.Forms.MaskedTextBox mskbxAliqIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioFamilia;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioLiquido;
        private System.Windows.Forms.MaskedTextBox mskbxDescINSS;
        private System.Windows.Forms.MaskedTextBox mskbxDescIRPF;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.CheckBox ckbxCasado;
    }
}

