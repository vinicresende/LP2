using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificaDesconto_Click(object sender, EventArgs e)
        {
            /* Variáveis Numericas
            estão dentro dos Try Parse e são:*/
            // double salarioBruto;
            // int numeroFilhos;
            double descINSS, descIRPF, salarioFamilia, salarioLiquido;
            string estadoCivil;

            if (double.TryParse(mskbxSalarioBruto.Text.Replace("R$", "  "), out double salarioBruto))
            {
                if (salarioBruto > 0)
                {
                    if (int.TryParse(mskbxNumeroFilhos.Text, out int numeroFilhos))
                    {
                        //Calculo INSS
                        if (salarioBruto <= 800.47)
                        {
                            mskbxAliqINSS.Text = "7,65%";
                            descINSS = salarioBruto * 7.65 / 100;
                        }
                        else if (salarioBruto <= 1050)
                        {
                            mskbxAliqINSS.Text = "8,65%";
                            descINSS = salarioBruto * 8.65 / 100;
                        }
                        else if (salarioBruto <= 1400.77)
                        {
                            mskbxAliqINSS.Text = "9,00%";
                            descINSS = salarioBruto * 9 / 100;
                        }
                        else if (salarioBruto <= 2801.56)
                        {
                            mskbxAliqINSS.Text = "11,00%";
                            descINSS = salarioBruto * 11 / 100;
                        }
                        else
                        {
                            mskbxAliqINSS.Text = "Teto";
                            descINSS = 308.17;
                        }
                        mskbxDescINSS.Text = descINSS.ToString("N2");

                        //Calculo IRPF
                        if (salarioBruto <= 1257.12)
                        {
                            mskbxAliqIRPF.Text = "0";
                            descIRPF = 0;
                        }
                        else if (salarioBruto <= 2512.08)
                        {
                            mskbxAliqIRPF.Text = "15,00%";
                            descIRPF = salarioBruto * 15 / 100;
                        }
                        else
                        {
                            mskbxAliqIRPF.Text = "27,50%";
                            descIRPF = salarioBruto * 27.5 / 100;
                        }
                        mskbxDescIRPF.Text = descIRPF.ToString("N2");

                        //SalarioFamilia
                        if (salarioBruto <= 435.52)
                        {
                            salarioFamilia = 22.33 * numeroFilhos;
                        }
                        else if (salarioBruto <= 654.61)
                        {
                            salarioFamilia = 15.74 * numeroFilhos;
                        }
                        else
                        {
                            salarioFamilia = 0;
                        }
                        mskbxSalarioFamilia.Text = salarioFamilia.ToString("N2");

                        //Salario Liquido
                        salarioLiquido = salarioBruto - descINSS - descIRPF + salarioFamilia;

                        mskbxSalarioLiquido.Text = salarioLiquido.ToString("N2");

                        //Dados do Label de Resultado:
                        if (ckbxCasado.Checked == true)
                            estadoCivil = "casado(a)";
                        else
                            estadoCivil = "solteiro(a)";
                        if (rbtnMasculino.Checked == true)
                        {

                            lblDados.Text = "Os descontos do salário do Sr. " +
                                             mskbxNomeFunc.Text + " que é " +
                                             estadoCivil + " e que tem " + mskbxNumeroFilhos.Text +
                                             " filho(s) são:";
                        }
                        else
                        {
                            lblDados.Text = "Os descontos do salário da Sra. " +
                                             mskbxNomeFunc.Text + " que é " +
                                             estadoCivil + " e que tem " + mskbxNumeroFilhos.Text +
                                             " filho(s) são:";
                        }


                    }
                    else
                        MessageBox.Show("Digite uma quantidade de filhos, pode ser 0");
                }
                else
                    MessageBox.Show("Digite um valor maior que 0 para o salário bruto");
            }
            else
                MessageBox.Show("Digite um valor válido para o salário bruto, coloque os centavos obrigatóriamente!");

        }
    }
}
