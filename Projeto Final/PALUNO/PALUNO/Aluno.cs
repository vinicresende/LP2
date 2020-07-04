using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PALUNO
{
    class Aluno
    {
        private int raaluno;
        private string nomealuno;
        private int cidadeidcidade;

        public int Raaluno
        {
            get
            {
                return raaluno;
            }
            set
            {
                raaluno = value;
            }
        }


        public string Nomealuno
        {
            get
            {
                return nomealuno;
            }
            set
            {
                nomealuno = value;
            }
        }



        public int Cidadeidcidade
        {
            get
            {
                return cidadeidcidade;
            }
            set
            {
                cidadeidcidade = value;
            }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daAluno;

            DataTable dtAluno = new DataTable();

            try
            {
                daAluno = new SqlDataAdapter("SELECT * FROM TBALUNO", frmPrincipal.conexao);
                daAluno.Fill(dtAluno);
                daAluno.FillSchema(dtAluno, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtAluno;
        }

        public int Salvar()
        {
            int retorno = 0;


            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO TBALUNO VALUES (@ra_aluno,@nome_aluno,@cidade_id_cidade)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@ra_aluno", SqlDbType.Int)); ;
                mycommand.Parameters.Add(new SqlParameter("@nome_aluno", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidade_id_cidade", SqlDbType.Int));

                mycommand.Parameters["@ra_aluno"].Value = raaluno;
                mycommand.Parameters["@nome_aluno"].Value = nomealuno;
                mycommand.Parameters["@cidade_id_cidade"].Value = cidadeidcidade;

                nReg = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;


            try
            {
                SqlCommand mycommand;
                int nReg = 0;
                mycommand = new SqlCommand("UPDATE TBALUNO SET nome_aluno = @nome_aluno ,cidade_id_cidade = @cidade_id_cidade WHERE ra_aluno = @ra_aluno", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@ra_aluno", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_aluno", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidade_id_cidade", SqlDbType.Int));

                mycommand.Parameters["@ra_aluno"].Value = raaluno;
                mycommand.Parameters["@nome_aluno"].Value = nomealuno;
                mycommand.Parameters["@cidade_id_cidade"].Value = cidadeidcidade;

                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }


        public int Excluir()
        {
            int nReg = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("DELETE FROM TBALUNO WHERE ra_aluno=@ra_aluno", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@ra_aluno", SqlDbType.Int));
                mycommand.Parameters["@ra_aluno"].Value = Convert.ToInt32(raaluno);

                nReg = mycommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return nReg;
        }


    }
}
