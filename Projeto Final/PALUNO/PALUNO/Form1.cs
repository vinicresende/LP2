using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;

namespace PALUNO
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=DESKTOP-F6MON1D\\SQLEXPRESS; Initial Catalog = LP2; Integrated Security = True");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de SQL " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Geral " + ex.Message);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var instancea = Application.OpenForms.OfType<frmCidade>().FirstOrDefault();
            if (instancea == null)
            {
                instancea = new frmCidade();
                instancea.MdiParent = this;
                instancea.WindowState = FormWindowState.Maximized;
                instancea.Show();
            }
            else
            {
                //instancea.Focus();
            }
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var instanceb = Application.OpenForms.OfType<frmAluno>().FirstOrDefault();
            if (instanceb == null)
            {
                instanceb = new frmAluno();
                instanceb.MdiParent = this;
                instanceb.WindowState = FormWindowState.Maximized;
                instanceb.Show();
            }
            else
            {
                //instanceb.Focus();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var instancec = Application.OpenForms.OfType<frmSobre>().FirstOrDefault();
            if (instancec == null)
            {
                instancec = new frmSobre();
                instancec.Show();
            }
            else
            {
                //instancec.Focus();
            }
        }
    }
}
