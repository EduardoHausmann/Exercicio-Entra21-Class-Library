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
        public string CadeiaConexaoCliente = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\Exercicio.mdf;Integrated Security=True;Connect Timeout=30";

        public void Inserir(Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoCliente;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO clientes (nome, cpf, data_nascimento, rg) VALUES (@NOME, @CPF, @DATANASCIMENTO, @RG)";
            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@DATANASCIMENTO", cliente.DataNascimento);
            comando.Parameters.AddWithValue("@RG", cliente.Rg);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Apagar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoCliente;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM clientes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Alterar(Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexaoCliente;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE clientes SET nome = @NOME, cpf = @CPF, data_nascimneto = @DATANASCIMENTO, rg = @RG WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", cliente.Id);
            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@DATANASCIMENTO", cliente.DataNascimento);
            comando.Parameters.AddWithValue("@RG", cliente.Rg);
            comando.ExecuteNonQuery();
            conexao.Close();

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
                cliente.DataNascimento = Convert.ToDateTime(linha["data_nascimento"]);
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
            cliente.DataNascimento = Convert.ToDateTime(linha["data_nascimento"]);
            cliente.Rg = linha["rg"].ToString();
            return cliente;
        }

    }
}
