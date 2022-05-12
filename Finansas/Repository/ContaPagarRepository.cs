using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public class ContaPagarRepository
    {
        public string CadeiaConexaoPagar = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Eduardo\Documents\GitHub\Exercicio-Entra21-Class-Library\Finansas\Repository\Database.mdf;Integrated Security=True";

        public int Inserir(ContaPagar contaPagar)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoPagar;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO contas_pagar (nome, valor, tipo) OUTPUT INSERTED.ID VALUES (@NOME, @VALOR, @TIPO)";
            comando.Parameters.AddWithValue("@NOME", contaPagar.Nome);
            comando.Parameters.AddWithValue("@VALOR", contaPagar.Valor);
            comando.Parameters.AddWithValue("@TIPO", contaPagar.Tipo);
            int id = Convert.ToInt32(comando.ExecuteScalar());
            conexao.Close();
            return id;
        }

        public bool Apagar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoPagar;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM contas_pagar WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            int qtdAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            conexao.Close();
            return qtdAfetada == 1;
        }

        public bool Alterar(ContaPagar contasPagar)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoPagar;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE contas_pagar SET nome = @NOME, valor = @VALOR, tipo = @TIPO WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", contasPagar.Nome);
            comando.Parameters.AddWithValue("@VALOR", contasPagar.Valor);
            comando.Parameters.AddWithValue("@TIPO", contasPagar.Tipo);
            comando.Parameters.AddWithValue("@ID", contasPagar.Id);
            int qtdAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            conexao.Close();
            return qtdAfetada == 1;
        }

        public List<ContaPagar> ObterTodos(string busca)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoPagar;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM contas_pagar WHERE nome LIKE @NOME";
            busca = "%" + busca + "%";
            comando.Parameters.AddWithValue("@NOME", busca);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();

            List<ContaPagar> contasPagar = new List<ContaPagar>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                ContaPagar contaPagar = new ContaPagar();
                contaPagar.Id = Convert.ToInt32(linha["id"]);
                contaPagar.Nome = linha["nome"].ToString();
                contaPagar.Valor = Convert.ToDecimal(linha["valor"]);
                contaPagar.Tipo = linha["tipo"].ToString();
                contasPagar.Add(contaPagar);
            }

            return contasPagar;
        }

        public ContaPagar ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoPagar;
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM contas_pagar WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            if (tabela.Rows.Count == 0)
            {
                return null;
            }

            DataRow linha = tabela.Rows[0];
            ContaPagar contaPagar = new ContaPagar();
            contaPagar.Id = id;
            contaPagar.Nome = linha["nome"].ToString();
            contaPagar.Valor = Convert.ToDecimal(linha["valor"]);
            contaPagar.Tipo = linha["tipo"].ToString();
            return contaPagar;
        }
    }
}
