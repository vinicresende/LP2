namespace Menu
{
    partial class frmExercicio4
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnCaracteresNum = new System.Windows.Forms.Button();
            this.btnPrimeiroBranco = new System.Windows.Forms.Button();
            this.btnCaracteresAlfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(131, 57);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(631, 280);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnCaracteresNum
            // 
            this.btnCaracteresNum.Location = new System.Drawing.Point(131, 412);
            this.btnCaracteresNum.Name = "btnCaracteresNum";
            this.btnCaracteresNum.Size = new System.Drawing.Size(179, 100);
            this.btnCaracteresNum.TabIndex = 1;
            this.btnCaracteresNum.Text = "Caracteres Numéricos";
            this.btnCaracteresNum.UseVisualStyleBackColor = true;
            this.btnCaracteresNum.Click += new System.EventHandler(this.btnCaracteresNum_Click);
            // 
            // btnPrimeiroBranco
            // 
            this.btnPrimeiroBranco.Location = new System.Drawing.Point(363, 412);
            this.btnPrimeiroBranco.Name = "btnPrimeiroBranco";
            this.btnPrimeiroBranco.Size = new System.Drawing.Size(179, 100);
            this.btnPrimeiroBranco.TabIndex = 2;
            this.btnPrimeiroBranco.Text = "Primeiro Branco";
            this.btnPrimeiroBranco.UseVisualStyleBackColor = true;
            this.btnPrimeiroBranco.Click += new System.EventHandler(this.btnPrimeiroBranco_Click);
            // 
            // btnCaracteresAlfa
            // 
            this.btnCaracteresAlfa.Location = new System.Drawing.Point(583, 412);
            this.btnCaracteresAlfa.Name = "btnCaracteresAlfa";
            this.btnCaracteresAlfa.Size = new System.Drawing.Size(179, 100);
            this.btnCaracteresAlfa.TabIndex = 3;
            this.btnCaracteresAlfa.Text = "Caracteres Alfabeticos";
            this.btnCaracteresAlfa.UseVisualStyleBackColor = true;
            this.btnCaracteresAlfa.Click += new System.EventHandler(this.btnCaracteresAlfa_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 593);
            this.Controls.Add(this.btnCaracteresAlfa);
            this.Controls.Add(this.btnPrimeiroBranco);
            this.Controls.Add(this.btnCaracteresNum);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnCaracteresNum;
        private System.Windows.Forms.Button btnPrimeiroBranco;
        private System.Windows.Forms.Button btnCaracteresAlfa;
    }
}