using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCaracteresNum_Click(object sender, EventArgs e)
        {
            //dias 10 melhores 1000 -  21 caracteres

            int contador = 0;

            for (var x=0; x <= rchtxtTexto.Text.Length -1; x++)
            {
                
                if (Char.IsNumber(rchtxtTexto.Text[x]))
                    contador += 1; //contador = contador + 1
            }
            MessageBox.Show("Caracteres numericos: " + contador);

        }

        private void btnPrimeiroBranco_Click(object sender, EventArgs e)
        {
            int x = 0;

            while(x<rchtxtTexto.Text.Length)
            {
                if (Char.IsWhiteSpace(rchtxtTexto.Text[x]))
                {
                    MessageBox.Show("Primeiro caracter branco: " + (x + 1));
                    break;
                }
                x += 1;
            }
        }

        private void btnCaracteresAlfa_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (char c in rchtxtTexto.Text)
            {
                if (Char.IsLetter(c))
                    contador += 1;
            }
            MessageBox.Show("Numero de Caracteres Alfabeticos: " + contador);
        }
    }
}
