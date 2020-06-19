using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace Atividade_7
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string auxiliar = "";
            string valor = "";

            for (var x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite um Valor na posição " + (x + 1), "Entrada de Dados");

                if (int.TryParse(valor, out Vetor[x]))
                {
                    //auxiliar = auxiliar + "\n" + Vetor[x].ToString(); concatena no final e não inverte 
                    auxiliar = Vetor[x].ToString() + "\n" + auxiliar; //concatenando no começo e inverte
                }
                else
                {
                    MessageBox.Show("Número Invalido!!");
                    x--; //decrementa para repedir a mesma entrada quando voltar no for.
                }

            }
            MessageBox.Show(auxiliar);
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string auxiliar = "";
            string valor = "";

            for (var x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite um Valor na posição " + (x + 1), "Entrada de Dados");
                if (!int.TryParse(valor, out Vetor[x]))
                {
                    MessageBox.Show("Número Invalido!!");
                    x--; //decrementa para repedir a mesma entrada quando voltar no for.
                }

            }
            Array.Reverse(Vetor);
            for (var x = 19; x <= 0; x--)
                auxiliar = auxiliar + "\n" + Vetor[x];
            /* Um jeito de Fazer sem o reverse
            for (var x=19;x<=0;x--)
                auxiliar = auxiliar + "\n" + Vetor[x].ToString()
            */
            MessageBox.Show(auxiliar);
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            double[] Preco = new double[10];
            double[] Quantidade = new double[10];
            double faturamento = 0;
            string valor = "";

            for (var x = 0; x < 10; x++)
            {
                valor = Interaction.InputBox("Quantidade da Mercadoria " + (x + 1) + ":", "Entrada de Dados");
                if (double.TryParse(valor, out Quantidade[x]))
                {
                    while (true)
                    {
                        valor = Interaction.InputBox("Valor da Mercadoria " + (x + 1) + ":", "Entrada de Dados");
                        if (double.TryParse(valor, out Preco[x]))
                            break;
                        else
                            MessageBox.Show("Digite o Valor da Mercadoria " + (x + 1) + " corretamente!!!");
                    }
                    faturamento += Quantidade[x] * Preco[x];
                }
                else
                {
                    MessageBox.Show("Digite a Quantidade da Mercadoria " + (x + 1) + " corretamente!!!");
                    x--;
                }
            }
            MessageBox.Show("Faturamento = R$" + faturamento.ToString("N2"));
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };
            Int32 I, Total = 0;
            Int32 N = Alunos.Length;
            for (I = 0; I < N - 1; I++)
            {
                Total += Alunos[I].Length;
            }
            MessageBox.Show(Total.ToString());
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais" };
            string auxiliar = "";
            ArrayList AlunosList = new ArrayList();
            AlunosList.AddRange(Alunos);
            AlunosList.Remove("Otávio");
            foreach (String str in AlunosList)
                auxiliar += str + "\n";
            MessageBox.Show(auxiliar);
        }

        private void btnExercicio6_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            double medias;
            int i, j;
            string valor, mediaFinal = "";
            for (i = 0; i < 20; i++)
            {
                medias = 0;
                for (j = 0; j < 3; j++)
                {
                    valor = Interaction.InputBox("Nota " + (j + 1) + " do aluno " + (i + 1) + ":", "Entrada das Notas");
                    if (double.TryParse(valor, out notas[i, j]))
                    {
                        medias += notas[i, j];
                    }
                    else
                    {
                        MessageBox.Show("Digite valores válidos para as notas!!!");
                        j--;
                    }
                }
                medias /= 3;
                mediaFinal += "Aluno "+ (i+1) + " : média: " + medias.ToString("N1") + "\n";
            }
            MessageBox.Show(mediaFinal);
        }
    }
}
