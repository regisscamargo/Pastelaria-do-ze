using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace ProjetoPastelariaDoZe_2022.DAO
{
    using System.Data;
    using System.Data.Common;

    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Compra_fiado { get; set; }
        public string Dia_fiado { get; set; }
        public string Senha { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="telefone"></param>
        /// <param name="senha"></param>
        /// <param name="compra_fiado"></param>
        /// <param name="dia_fiado"></param>
        public Cliente(int id = 0, string nome = "", string cpf = "", string telefone = "", string senha = "", string compra_fiado = "", string dia_fiado = "")
        {
            IdCliente = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Compra_fiado = compra_fiado;
            Dia_fiado = dia_fiado;
            Senha = senha;
        }
    }
    public class ClienteDAO
    {
        /// <summary>
        /// Utilização de mais do que um provider com o mesmo script (MySQL, SQLServer, Firebird...)
        /// </summary>
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public ClienteDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }
        public void InserirDbProvider(Cliente cliente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var nome = comando.CreateParameter(); nome.ParameterName = "@nome";
            nome.Value = cliente.Nome; comando.Parameters.Add(nome);
            var cpf = comando.CreateParameter(); cpf.ParameterName = "@cpf";
            cpf.Value = cliente.Cpf; comando.Parameters.Add(cpf);
            var telefone = comando.CreateParameter(); telefone.ParameterName = "@telefone";
            telefone.Value = cliente.Telefone; comando.Parameters.Add(telefone);
            var compra_fiado = comando.CreateParameter(); compra_fiado.ParameterName = "@compra_fiado";
            compra_fiado.Value = cliente.Compra_fiado; comando.Parameters.Add(compra_fiado);
            var dia_fiado = comando.CreateParameter(); dia_fiado.ParameterName = "@dia_fiado";
            dia_fiado.Value = cliente.Dia_fiado; comando.Parameters.Add(dia_fiado);
            var senha = comando.CreateParameter(); senha.ParameterName = "@senha";
            senha.Value = cliente.Senha; comando.Parameters.Add(senha);
            conexao.Open();
            comando.CommandText = @"INSERT INTO Cliente(nome, cpf, telefone, compra_fiado, dia_fiado, senha) VALUES
(@nome,@cpf,@telefone,@compra_fiado,@dia_fiado,@senha)";
            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using faz o Close() automático quando fecha o seu escopo

            throw new NotImplementedException();

        }
        public DataTable SelectDbProvider(Cliente cliente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro por ID e personaliza o sql do filtro
            string auxSqlFiltro = " ";
            if (cliente.IdCliente > 0)
            {
                auxSqlFiltro = " WHERE id = " + cliente.IdCliente + " ";
            }
            //Adicona parâmetro (@campo e valor)
            conexao.Open();
            comando.CommandText = @"" +
            "SELECT * " +
            "FROM Cliente " +
            auxSqlFiltro +
            "ORDER BY nome;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }

        public void ExcluirDbProvider(Cliente cliente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetros (@campo e valor)
            var idCliente = comando.CreateParameter();
            idCliente.ParameterName = "@idCliente";
            idCliente.Value = cliente.IdCliente;
            comando.Parameters.Add(idCliente);
            conexao.Open();
            comando.CommandText = @"" +
            "DELETE FROM Cliente " +
            "WHERE id = @idCliente;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
        }

        public void EditarDbProvider(Cliente cliente)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var idCliente = comando.CreateParameter(); idCliente.ParameterName = "@idCliente";
            idCliente.Value = cliente.IdCliente; comando.Parameters.Add(idCliente);
            var nome = comando.CreateParameter(); nome.ParameterName = "@nome";
            nome.Value = cliente.Nome; comando.Parameters.Add(nome);
            var cpf = comando.CreateParameter(); cpf.ParameterName = "@cpf";
            cpf.Value = cliente.Cpf; comando.Parameters.Add(cpf);
            var telefone = comando.CreateParameter(); telefone.ParameterName = "@telefone";
            telefone.Value = cliente.Telefone; comando.Parameters.Add(telefone);
            var compra_fiado = comando.CreateParameter(); compra_fiado.ParameterName = "@compra_fiado";
            compra_fiado.Value = cliente.Compra_fiado; comando.Parameters.Add(compra_fiado);
            var dia_fiado = comando.CreateParameter(); dia_fiado.ParameterName = "@dia_fiado";
            dia_fiado.Value = cliente.Dia_fiado; comando.Parameters.Add(dia_fiado);
            var senha = comando.CreateParameter(); senha.ParameterName = "@senha";
            senha.Value = cliente.Senha; comando.Parameters.Add(senha);

            conexao.Open();
            comando.CommandText = @"UPDATE Cliente " + "SET nome = @nome,cpf = @cpf,telefone = @telefone,compra_fiado = @compra_fiado,dia_fiado = @dia_fiado,senha = @senha" + " WHERE id = @idCliente;";
            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
            //using faz o Close() automático quando fecha o seu escopo

        }
    }
}