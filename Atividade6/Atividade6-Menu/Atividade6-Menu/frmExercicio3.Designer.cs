namespace Atividade6_Menu
{
    partial class frmExercicio3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercicio3));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPalavraouFrase = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.btnTestarPalindromo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(173, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(285, 22);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "EXERCÍCIO 3 - PALÍNDROMOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPalavraouFrase
            // 
            this.lblPalavraouFrase.AutoSize = true;
            this.lblPalavraouFrase.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavraouFrase.Location = new System.Drawing.Point(39, 205);
            this.lblPalavraouFrase.Name = "lblPalavraouFrase";
            this.lblPalavraouFrase.Size = new System.Drawing.Size(119, 15);
            this.lblPalavraouFrase.TabIndex = 7;
            this.lblPalavraouFrase.Text = "Palara ou Frase:";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra.Location = new System.Drawing.Point(164, 200);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(383, 21);
            this.txtPalavra.TabIndex = 8;
            // 
            // btnTestarPalindromo
            // 
            this.btnTestarPalindromo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestarPalindromo.Location = new System.Drawing.Point(252, 293);
            this.btnTestarPalindromo.Name = "btnTestarPalindromo";
            this.btnTestarPalindromo.Size = new System.Drawing.Size(110, 65);
            this.btnTestarPalindromo.TabIndex = 9;
            this.btnTestarPalindromo.Text = "Testar se é palíndromo";
            this.btnTestarPalindromo.UseVisualStyleBackColor = true;
            this.btnTestarPalindromo.Click += new System.EventHandler(this.btnTestarPalindromo_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.btnTestarPalindromo);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.lblPalavraouFrase);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExercicio3";
            this.Text = "Exercício 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPalavraouFrase;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Button btnTestarPalindromo;
    }
}