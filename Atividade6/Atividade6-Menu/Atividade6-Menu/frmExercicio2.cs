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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double H=0.0;
            if (Int32.TryParse(txtN.Text, out int N) && N>0)
            {
                for(double x=1; x <= N; x++)
                {
                    H += (1.00 / x);
                }
                MessageBox.Show("H = " + H);
            }
            else
                MessageBox.Show("Digite um número Inteiro, positivo e diferente de 0!");
        }
    }
}
