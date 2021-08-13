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
    public class ClienteRepositorio
    {
        public string CadeiaConexaoCliente = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Eduardo\Documents\GitHub\Exercicio-Entra21-Class-Library\Finansas\Repository\Database.mdf;Integrated Security=True";

        public int Inserir(Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoCliente;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO clientes (nome, cpf, rg) VALUES (@NOME, @CPF, @RG)";
            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@RG", cliente.Rg);
            int id = Convert.ToInt32(comando.ExecuteScalar());
            conexao.Close();
            return id;
        }

        public bool Apagar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoCliente;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM clientes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            int qtdAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            conexao.Close();
            return qtdAfetada == 1;
        }

        public bool Alterar(Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoCliente;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE clientes SET nome = @NOME, cpf = @CPF, rg = @RG WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", cliente.Id);
            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@RG", cliente.Rg);
            int qtdAfetada = Convert.ToInt32(comando.ExecuteNonQuery());
            conexao.Close();
            return qtdAfetada == 1;

        }

        public List<Cliente> ObterTodos(string busca)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoCliente;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM clientes WHERE nome LIKE @NOME";
            busca = "%" + busca + "%";
            comando.Parameters.AddWithValue("@NOME", busca);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();

            List<Cliente> clientes = new List<Cliente>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];

                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(linha["id"]);
                cliente.Nome = linha["nome"].ToString();
                cliente.Cpf = linha["cpf"].ToString();
                cliente.Rg = linha["rg"].ToString();
                clientes.Add(cliente);
            }

            return clientes;
        }

        public Cliente ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoCliente;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM clientes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            if (tabela.Rows.Count == 0)
            {
                return null;
            }

            DataRow linha = tabela.Rows[0];
            Cliente cliente = new Cliente();
            cliente.Id = id;
            cliente.Nome = linha["nome"].ToString();
            cliente.Cpf = linha["cpf"].ToString();
            cliente.Rg = linha["rg"].ToString();
            return cliente;
        }

    }
}
