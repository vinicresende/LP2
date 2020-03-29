using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            double A, B, C; //Lados do Triângulo

            if (double.TryParse(txtA.Text,out A) && double.TryParse(txtB.Text,out B) && double.TryParse(txtC.Text,out C)) //Entrada Numérica
            {
                if (A>0 && B>0 && C>0)
                {
                    bool testeA1, testeA2, testeB1, testeB2, testeC1, testeC2;
                    testeA1 = (A > Math.Abs(B - C));
                    testeA2 = (A < (B + C));
                    testeB1 = (B > Math.Abs(A - C));
                    testeB2 = (B < (A + C));
                    testeC1 = (C > Math.Abs(A - B));
                    testeC2 = (C < (A + B));
                    if (testeA1 && testeA2 && testeB1 && testeB2 && testeC1 && testeC2) //É um triângulo
                    {
                        //Triangulo Equilátero
                        if (A == B && A == C)
                        {
                            lblResultado.Text = "É um triangulo Equilátero";
                            picTriangulo.Image = Properties.Resources.imgEquilatero;
                            picTriangulo.Visible = true;
                        }
                        //Triangulo Isóceles
                        else
                        {
                            if (A == B || A == C || B == C)
                            {
                                lblResultado.Text = "É um triangulo Isóceles";
                                picTriangulo.Image = Properties.Resources.imgIsoceles2;
                                picTriangulo.Visible = true;
                            }
                            //Triangulo Escaleno.
                            else
                            {
                                lblResultado.Text = "É um triangulo Escaleno";
                                picTriangulo.Image = Properties.Resources.imgEscaleno;
                                picTriangulo.Visible = true;
                            }

                        }
                    }
                    else //Não é um triângulo
                    {
                        lblResultado.Text = "Não é um triângulo";
                        picTriangulo.Image = Properties.Resources.imgError;
                        picTriangulo.Visible = true;
                    }
                }
                else
                    MessageBox.Show("Insira valores positivos o teste", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Entrada não numérica
                MessageBox.Show("Insira entradas numéricas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
