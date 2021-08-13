using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ContaReceberRepositorio
    {
        public string CadeiaConexaoReceber = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Eduardo\Documents\GitHub\Exercicio-Entra21-Class-Library\Finansas\Repository\Database.mdf;Integrated Security=True";

        public int Inserir(ContaReceber contaReceber)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoReceber;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO contas_receber (nome, valor, valor_recebido) VALUES (@NOME, @VALOR, @VALORRECEBIDO)";
            comando.Parameters.AddWithValue("@NOME", contaReceber.Nome);
            comando.Parameters.AddWithValue("@VALOR", contaReceber.Valor);
            comando.Parameters.AddWithValue("@VALORRECEBIDO", contaReceber.ValorRecebido);
            int id = Convert.ToInt32(comando.ExecuteScalar());
            conexao.Close();
            return id;
        }

        public bool Alterar(ContaReceber contaReceber)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoReceber;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE contas_receber SET nome = @NOME, valor = @VALOR, valor_recebido = @VALORRECEBIDO WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", contaReceber.Id);
            comando.Parameters.AddWithValue("@NOME", contaReceber.Nome);
            comando.Parameters.AddWithValue("@VALOR", contaReceber.Valor);
            comando.Parameters.AddWithValue("@VALORRECEBIDO", contaReceber.ValorRecebido);
            int qtdAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            conexao.Close();
            return qtdAfetada == 1;
        }

        public bool Apagar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoReceber;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM contas_receber WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            int qtdAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            conexao.Close();
            return qtdAfetada == 1;
        }

        public List<ContaReceber> ObterTodos(string busca)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoReceber;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM contas_receber WHERE nome LIKE @NOME";
            busca = "%" + busca + "%";
            comando.Parameters.AddWithValue("@NOME", busca);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();

            List<ContaReceber> contasReceber = new List<ContaReceber>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                ContaReceber contaReceber = new ContaReceber();
                contaReceber.Id = Convert.ToInt32(linha["id"]);
                contaReceber.Nome = linha["nome"].ToString();
                contaReceber.Valor = Convert.ToDecimal(linha["valor"]);
                contaReceber.ValorRecebido = Convert.ToDecimal(linha["valor_recebido"]);
                contasReceber.Add(contaReceber);
            }
            return contasReceber;
        }

        public ContaReceber ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoReceber;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM contas_receber WHERE id = @ID";
            comando.Parameters.AddWithValue("@Id", id);
            comando.ExecuteNonQuery();

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            if (tabela.Rows.Count == 0)
            {
                return null;
            }

            DataRow linha = tabela.Rows[0];
            ContaReceber contaReceber = new ContaReceber();
            contaReceber.Id = id;
            contaReceber.Nome = linha["nome"].ToString();
            contaReceber.Valor = Convert.ToDecimal(linha["valor"]);
            contaReceber.ValorRecebido = Convert.ToDecimal(linha["valor_recebido"]);
            return contaReceber;

        }
    }
}
