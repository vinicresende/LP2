using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PALUNO
{
    public partial class frmAluno : Form
    {
        private BindingSource bnAluno = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsAluno = new DataSet();
        private DataSet dsCidade = new DataSet();
        public frmAluno()
        {
            InitializeComponent();
        }
        private void frmAluno_Load(object sender, EventArgs e)
        {

            try
            {

                Aluno Alu = new Aluno();
                dsAluno.Tables.Add(Alu.Listar());
                bnAluno.DataSource = dsAluno.Tables["TBALUNO"];
                dgvAluno.DataSource = bnAluno;
                bnvAluno.BindingSource = bnAluno;

                txtRa.DataBindings.Add("TEXT", bnAluno, "ra_aluno");
                txtNomeAluno.DataBindings.Add("TEXT", bnAluno, "nome_aluno");
                

                // tbcidade : id_cidade --> tbaluno : cidade_id_cidade

                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());

                cbxCidade.DataSource = dsCidade.Tables["TbCidade"];

                //CAMPO QUE SERÁ MOSTRADO PARA O USUÁRIO

                cbxCidade.DisplayMember = "nome_cidade";

                //CAMPO QUE É A CHAVE DA TABELA CIDADE E QUE LIGA COM A TABELA DE ALUNO

                cbxCidade.ValueMember = "id_cidade";


                //No momento de linkar os componentes com o Binding Source linkar também o combox da cidade

                cbxCidade.DataBindings.Add("SelectedValue", bnAluno, "cidade_id_cidade"); // AJUSTAR DROPDOWNSTYLE PARA DropDownList PARA NAO DEIXAR INCLUIR
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                TabControl1.SelectTab(1);
            }

            bnAluno.AddNew();
            txtRa.Enabled = true;
            txtNomeAluno.Enabled = true;
            cbxCidade.Enabled = true;
            cbxCidade.SelectedIndex = 0;
            txtNomeAluno.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = true; ;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                TabControl1.SelectTab(1);
            }


            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Aluno RegAlu = new Aluno();

                RegAlu.Raaluno = Convert.ToInt32(txtRa.Text);
                RegAlu.Nomealuno = txtNomeAluno.Text;
                RegAlu.Cidadeidcidade = Convert.ToInt32(cbxCidade.SelectedValue);

                if (RegAlu.Excluir() > 0)
                {
                    MessageBox.Show("Aluno excluído com sucesso!");
                    Aluno R = new Aluno();
                    dsAluno.Tables.Clear();
                    dsAluno.Tables.Add(R.Listar());
                    bnAluno.DataSource = dsAluno.Tables["TBALUNO"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir aluno!");
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // validar os dados
            if (txtNomeAluno.Text == "")
                MessageBox.Show("Nome do Aluno inválido!");
            else if (Int32.TryParse(txtRa.Text, out int ra) && ra>0)
            {
                Aluno RegAlu = new Aluno();

                RegAlu.Raaluno = ra;
                RegAlu.Nomealuno = txtNomeAluno.Text;
                RegAlu.Cidadeidcidade = Convert.ToInt32(cbxCidade.SelectedValue);

                if (bInclusao)
                {
                    if (RegAlu.Salvar() > 0)
                    {
                        MessageBox.Show("Aluno adicionada com sucesso!");

                        btnSalvar.Enabled = false;
                        txtRa.Enabled = false;
                        txtNomeAluno.Enabled = false;
                        cbxCidade.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        // recarrega o grid
                        dsAluno.Tables.Clear();
                        dsAluno.Tables.Add(RegAlu.Listar());
                        bnAluno.DataSource = dsAluno.Tables["TBALUNO"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar aluno!");
                    }
                }
                else
                {
                    if (RegAlu.Alterar() > 0)
                    {
                        MessageBox.Show("Aluno alterado com sucesso!");

                        dsAluno.Tables.Clear();
                        dsAluno.Tables.Add(RegAlu.Listar());
                        txtRa.Enabled = false;
                        txtNomeAluno.Enabled = false;
                        cbxCidade.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar aluno!");
                    }

                }
            }
            else
                MessageBox.Show("RA Inválido!");

        }



        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 0)
            {
                TabControl1.SelectTab(1);
            }

            txtNomeAluno.Enabled = true;
            cbxCidade.Enabled = true;
            txtNomeAluno.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            bnAluno.CancelEdit();

            btnSalvar.Enabled = false;
            txtRa.Enabled = false;
            txtNomeAluno.Enabled = false;
            cbxCidade.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
