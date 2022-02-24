using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AS_RESERVASALAS
{
    internal class BaseDados
    {
        string strLigacao;
        SqlConnection LigacaoBD;

        public BaseDados()
        {
            LigacaoBD = new SqlConnection("Data Source = 193.137.7.32; Persist Security Info=True;User ID = diei2119; Password=DI@2021");
            LigacaoBD.Open();
        }
        ~BaseDados()
        {
            try
            {
                LigacaoBD.Close();
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }

        public void executa_SQL(string sql)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = sql;
            comando.Connection = LigacaoBD;
            comando.ExecuteNonQuery();
            comando.Dispose();
        }


        public void executa_SQL(string sql, List<SqlParameter> parametros)
        {
            SqlCommand comando = new SqlCommand(sql, LigacaoBD);
            comando.Parameters.AddRange(parametros.ToArray());
            comando.ExecuteNonQuery();
            comando.Dispose();
        }


        public SqlTransaction iniciar_transacao()
        {
            return LigacaoBD.BeginTransaction();
        }


        public void executa_SQL(string sql, List<SqlParameter> parametros, SqlTransaction transacao)
        {
            SqlCommand comando = new SqlCommand(sql, LigacaoBD);
            comando.Parameters.AddRange(parametros.ToArray());
            comando.Transaction = transacao;

            if (comando.ExecuteNonQuery() > 0)
            {
                transacao.Commit();
            }
            else
            {
                transacao.Rollback();
            }

            comando.Dispose();
        }


        public DataTable devolveconsulta(string sql)
        {
            SqlCommand comando = new SqlCommand(sql, LigacaoBD);
            DataTable registos = new DataTable();
            SqlDataReader dados = comando.ExecuteReader();
            registos.Load(dados);
            comando.Dispose();
            return registos;

        }

        public DataTable devolveconsulta(string sql, List<SqlParameter> param)
        {
            SqlCommand comando = new SqlCommand(sql, LigacaoBD);
            comando.Parameters.AddRange(param.ToArray());
            DataTable registos = new DataTable();
            SqlDataReader dados = comando.ExecuteReader();
            registos.Load(dados);
            comando.Dispose();
            return registos;

        }
    
}
}
