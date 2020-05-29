using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6_Menu
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcularSalarioBruto_Click(object sender, EventArgs e)
        {
            double A, B, C, D;
            /* A = Salário Bruto
             * B = Produção >= 100
             * C = Produção >= 120
             * D = Produção >= 150
             * A = A + A * (0.05*B + 0.1*C + 0.1*D)+gratificacao
             */
            if (Double.TryParse(txtProducao.Text, out double producao) && producao >= 0 &&
                Double.TryParse(txtSalario.Text, out double salario) && salario >= 0 &&
                Double.TryParse(txtGratificacao.Text, out double gratificacao) && gratificacao >= 0)
            {
                A = salario;
                B = producao >= 100 ? 1 : 0;
                C = producao >= 120 ? 1 : 0;
                D = producao >= 150 ? 1 : 0;

                A = A + A * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacao;

                A = A <= 7000 ? A : ((D == 1 && gratificacao > 0) ? A : 7000);

                txtSalarioBrutoTotal.Text = "R$ "+A.ToString("N2");

                MessageBox.Show("Nome: " + txtNome.Text +
                    "\nCargo: " + txtCargo.Text +
                    "\nNúmero de Inscrição: " + txtNumInscricao.Text +
                    "\nProdução: " + txtProducao.Text +
                    "\nSalário Base: " + txtSalario.Text +
                    "\nGratificação: " + txtGratificacao.Text +
                    "\n\n\nSalário Bruto Total: R$" + A.ToString("N2"));


            }
            else
            {
                txtSalarioBrutoTotal.Text = "ERRO";
                MessageBox.Show("Digite um Valor numérico Válido para Produção, Salário e Gratificação!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         }
    }
}
