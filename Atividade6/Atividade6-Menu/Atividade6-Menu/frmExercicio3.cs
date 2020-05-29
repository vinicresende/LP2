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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnTestarPalindromo_Click(object sender, EventArgs e)
        {
            string texto = txtPalavra.Text;
            texto = texto.Replace(" ","");
            texto = texto.ToUpper();

            string textoInvertido;
            char[] arraytexto = texto.ToCharArray();
            Array.Reverse(arraytexto);
            textoInvertido = new string(arraytexto);

            if (texto == textoInvertido)
                MessageBox.Show("É uma expressão Palíndroma!!!");
            else
                MessageBox.Show("Não é uma expressão Palíndroma!!!");

        }
    }
}
