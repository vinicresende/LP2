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
    public partial class frmExercicio1 : Form
    {
        int contador; //CONTADOR GLOBAL
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnEspacoBranco_Click(object sender, EventArgs e) //CONTADOR DE ESPAÇOS EM BRANCO
        {
            contador = 0;
            for (var x = 0; x <= rchtxtFrase.Text.Length - 1; x++)
            {

                if (rchtxtFrase.Text[x]==32)
                    contador += 1;
            }
            MessageBox.Show("Espaços em Branco: " + contador);
        }

        private void btnLetrasR_Click(object sender, EventArgs e)
        {
            contador = 0;
            int x = 0;
            while (x < rchtxtFrase.Text.Length)
            {
                if (Char.ToUpper(rchtxtFrase.Text[x]) == 'R')
                {
                    contador += 1;
                }
                x += 1;
            }
            MessageBox.Show("Número de Letras 'R' no texto: " + contador);
        }

        private void btnParLetras_Click(object sender, EventArgs e)
        {
            int tam = rchtxtFrase.Text.Length;
            contador = 0;

            if(tam>1)
            {
                for (var x=1; x < tam; x++)
                {
                    if (Char.ToUpper(rchtxtFrase.Text[x]) == Char.ToUpper(rchtxtFrase.Text[x - 1]))
                        contador++;
                }
            }
            MessageBox.Show("Número de Letras Repetidas consecutivas: " + contador);
        }

        
    }
}
