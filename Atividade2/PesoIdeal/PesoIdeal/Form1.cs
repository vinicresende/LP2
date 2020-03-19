using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, pesoAtual, pesoIdeal; //Variáveis locais
            if(rbtnMasculino.Checked) //BOTÃO MASCULINO ESTÁ CHECKADO
            {
                
                if (double.TryParse(txtAltura.Text, out altura) && double.TryParse(txtPeso.Text, out pesoAtual)) //TENTATIVA DE CONVERSÃO PARA NÚMERO
                {
                    pesoIdeal = 72.7 * altura - 58;
                    pesoIdeal = Math.Round(pesoIdeal, 1);
                    lblResultadoPesoIdeal.Text = pesoIdeal.ToString();

                    if (pesoAtual < pesoIdeal)
                    {
                        lblResultadoSituacao.Text = "Abaixo do Peso Ideal - Ganhe massa!!";
                        lblResultadoSituacao.ForeColor = Color.FromArgb(255, 0, 0);
                    }
                    else if (pesoAtual > pesoIdeal)
                    {
                        lblResultadoSituacao.Text = "Acima do Peso Ideal - Perca massa!!";
                        lblResultadoSituacao.ForeColor = Color.FromArgb(255, 0, 0);
                    }
                    else
                    {
                        lblResultadoSituacao.Text = "Você está no Peso Ideal - Parabéns!!";
                        lblResultadoSituacao.ForeColor = Color.FromArgb(0, 0, 255);
                    }
                }
                else //NÃO É NÚMERICA A ENTRADA
                    MessageBox.Show("Insira entradas válidas para Altura e Peso", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else //BOTÃO MASCULINO NÃO CHECKADO
            {
                if (double.TryParse(txtAltura.Text, out altura) && double.TryParse(txtPeso.Text, out pesoAtual)) //TENTATIVA DE CONVERSÃO PARA NÚMERO
                {
                    pesoIdeal = 62.1 * altura - 44.7;
                    pesoIdeal = Math.Round(pesoIdeal, 1);
                    lblResultadoPesoIdeal.Text = pesoIdeal.ToString();

                    if (pesoAtual < pesoIdeal)
                    {
                        lblResultadoSituacao.Text = "Abaixo do Peso Ideal - Ganhe massa!!";
                        lblResultadoSituacao.ForeColor = Color.FromArgb(255, 0, 0);
                    }
                    else if (pesoAtual > pesoIdeal)
                    {
                        lblResultadoSituacao.Text = "Acima do Peso Ideal - Perca massa!!";
                        lblResultadoSituacao.ForeColor = Color.FromArgb(255, 0, 0);
                    }
                    else
                    {
                        lblResultadoSituacao.Text = "Você está no Peso Ideal - Parabéns!!";
                        lblResultadoSituacao.ForeColor = Color.FromArgb(0, 0, 255);
                    }
                }
                else //NÃO É NÚMERICA A ENTRADA
                    MessageBox.Show("Insira entradas válidas para Altura e Peso", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar==',' || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}
