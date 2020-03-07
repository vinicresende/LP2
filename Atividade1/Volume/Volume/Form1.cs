using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Calc_Click(object sender, EventArgs e)
        {
            double Raio, Altura;

            if ((double.TryParse(tx_Raio.Text, out Raio) &&  double.TryParse(tx_Altura.Text, out Altura)))
            {
                if (Raio > 0 && Altura > 0)
                {
                    double Volume = Math.PI * Math.Pow(Raio, 2) * Altura;
                    tx_Volume.Text = Volume.ToString("N4");

                    lb_r.Text = "r = " + Raio.ToString();
                    lb_h.Text = "h = " + Altura.ToString();
                    lb_Vol.Text = "Vol = " + Volume.ToString("N4");
                }
                else MessageBox.Show("Digite valores maiores do que 0!");
            }
            else MessageBox.Show("Dados Inválidos, digite dados Numéricos!");
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tx_Altura.Clear();
            tx_Raio.Clear();
            tx_Volume.Clear();
        }
    }
}
