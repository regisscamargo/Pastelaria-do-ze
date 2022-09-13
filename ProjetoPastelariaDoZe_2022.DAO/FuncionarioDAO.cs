using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace ProjetoPastelariaDoZe_2022.DAO
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public string Matricula { get; set; }
        public int Grupo { get; set; }
        public Funcionario(int id = 0, string nome = "", string cpf = "", string telefone = "", string senha = "", string matricula = "", int grupo = 0)
        {
            IdFuncionario = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Senha = senha;
            Matricula = matricula;
            Grupo = grupo;
        }
    }
    public class FuncionarioDAO
    {
        /// <summary>
        /// Utilização de mais do que um provider com o mesmo script (MySQL, SQLServer, Firebird...)
        /// </summary>
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public FuncionarioDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public void InserirDbProvider(Funcionario funcionario)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetro (@campo e valor)
            var nome = comando.CreateParameter(); nome.ParameterName = "@nome";
            nome.Value = funcionario.Nome; comando.Parameters.Add(nome);
            var cpf = comando.CreateParameter(); cpf.ParameterName = "@cpf";
            cpf.Value = funcionario.Cpf; comando.Parameters.Add(cpf);
            var telefone = comando.CreateParameter(); telefone.ParameterName = "@telefone";
            telefone.Value = funcionario.Telefone; comando.Parameters.Add(telefone);
            var senha = comando.CreateParameter(); senha.ParameterName = "@senha";
            senha.Value = funcionario.Senha; comando.Parameters.Add(senha);
            var maticula = comando.CreateParameter(); maticula.ParameterName = "@matricula";
            maticula.Value = funcionario.Matricula; comando.Parameters.Add(maticula);
            var grupo = comando.CreateParameter(); grupo.ParameterName = "@grupo";
            grupo.Value = funcionario.Grupo; comando.Parameters.Add(grupo);
            conexao.Open();
            comando.CommandText = @"INSERT INTO Funcionario(nome, cpf, telefone, senha, matricula, grupo) VALUES
(@nome,@cpf,@telefone,@senha,@matricula,@grupo)";
            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();


            //using faz o Close() automático quando fecha o seu escopo

            throw new NotImplementedException();
        }
        public DataTable SelectDbProvider(Funcionario funcionario)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //verifica se tem filtro
                                           //Adiciona parâmetro (@campo e valor)
            conexao.Open();
            comando.CommandText = @"SELECT id AS ID, nome AS Nome, cpf AS CPF,
telefone AS Telefone, matricula AS Matricula, grupo AS Grupo FROM Funcionario";

            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }
    }
}

