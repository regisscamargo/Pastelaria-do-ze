using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace ProjetoPastelariaDoZe_2022.DAO
{

    public class Comanda
    {
        public int IdComanda { get; set; }
        public string NumeroComanda { get; set; }
        public DateTime DataHora { get; set; }
        public int StatusComanda { get; set; }
        //parte do pagamento/fiado
        public int IdCliente { get; set; }
        public int IdFuncionario { get; set; }
        public DateTime DataAssinaturaFiado { get; set; }
        public int StatusPagamento { get; set; }
        public Comanda(int idComanda = 0, string numeroComanda = "", DateTime dataHora = default, int statusComanda = 0, int idCliente = 0, int idFuncionario = 0, DateTime dataAssinaturaFiado = default, int statusPagamento = 0)
        {
            IdComanda = idComanda;
            NumeroComanda = numeroComanda;
            DataHora = dataHora;
            StatusComanda = statusComanda;
            IdCliente = idCliente;
            IdFuncionario = idFuncionario;
            DataAssinaturaFiado = dataAssinaturaFiado;
            StatusPagamento = statusPagamento;
        }

        public override string ToString()
        {
            return NumeroComanda;
        }
    }

    public class ComandaDAO
    {
        /// <summary>
        /// Utilização de mais do que um provider com o mesmo script (MySQL, SQLServer, Firebird...)
        /// </summary>
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }
        public ComandaDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }


        public bool AbreNovaComanda(Comanda comanda)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetros (@campo e valor)
            var numeroComanda = comando.CreateParameter();
            numeroComanda.ParameterName = "@numeroComanda";
            numeroComanda.Value = comanda.NumeroComanda;
            comando.Parameters.Add(numeroComanda);
            var dataHora = comando.CreateParameter();
            dataHora.ParameterName = "@dataHora";
            dataHora.Value = comanda.DataHora;
            comando.Parameters.Add(dataHora);
            var statusComanda = comando.CreateParameter();
            statusComanda.ParameterName = "@statusComanda";
            statusComanda.Value = comanda.StatusComanda;
            comando.Parameters.Add(statusComanda);
            conexao.Open();
            // antes de abrir a comanda validar se ela já não esta aberta
            comando.CommandText = @"SELECT id_comanda FROM tb_comanda WHERE status_comanda = @statusComanda and comanda = @numeroComanda";
            DataTable qtdaComandas = new();
            qtdaComandas.Load(comando.ExecuteReader());
            if (qtdaComandas.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                comando.CommandText = @"INSERT INTO tb_comanda(comanda, data_hora, status_comanda) VALUES (@numeroComanda, @dataHora, @statusComanda)";
                var linhas = comando.ExecuteNonQuery();
                return true;
            }
        }

        public DataTable ListaComandas(Comanda comanda)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetros (@campo e valor)
            var statusComanda = comando.CreateParameter();
            statusComanda.ParameterName = "@statusComanda";
            statusComanda.Value = comanda.StatusComanda;
            comando.Parameters.Add(statusComanda);
            conexao.Open();
            comando.CommandText = @"" +
            "SELECT id_comanda AS ID, comanda AS Comanda, data_hora AS Data, status_comanda AS Status " +
            "FROM tb_comanda " +
            "WHERE status_comanda = @statusComanda";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }

        public class ComandaProdutos
        {
            public int IdComandaProduto { get; set; }
            public int IdComanda { get; set; }
            public int IdProduto { get; set; }
            public int Quantidade { get; set; }
            public double ValorUnitario { get; set; }
            public int IdFuncionario { get; set; }
            public ComandaProdutos(int idComandaProduto = 0, int idComanda = 0, int
            idProduto = 0, int quantidade = 0, double valorUnitario = 0, int idFuncionario
            = 0)
            {
                IdComandaProduto = idComandaProduto;
                IdComanda = idComanda;
                IdProduto = idProduto;
                Quantidade = quantidade;
                ValorUnitario = valorUnitario;
                IdFuncionario = idFuncionario;
            }
        }

        public void AddItemComanda(ComandaProdutos comandaProdutos)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetros (@campo e valor)
            var idComanda = comando.CreateParameter();
            idComanda.ParameterName = "@idComanda";
            idComanda.Value = comandaProdutos.IdComanda;
            comando.Parameters.Add(idComanda);
            var idProduto = comando.CreateParameter();
            idProduto.ParameterName = "@idProduto";
            idProduto.Value = comandaProdutos.IdProduto;
            comando.Parameters.Add(idProduto);
            var quantidade = comando.CreateParameter();
            quantidade.ParameterName = "@quantidade";
            quantidade.Value = comandaProdutos.Quantidade;
            comando.Parameters.Add(quantidade);
            var valorUnitario = comando.CreateParameter();
            valorUnitario.ParameterName = "@valorUnitario";
            valorUnitario.Value = comandaProdutos.ValorUnitario;
            comando.Parameters.Add(valorUnitario);
            var idFuncionario = comando.CreateParameter();
            idFuncionario.ParameterName = "@idFuncionario";
            idFuncionario.Value = comandaProdutos.IdFuncionario;
            comando.Parameters.Add(idFuncionario);
            conexao.Open();
            comando.CommandText = @"" +
            "INSERT INTO tb_comanda_produto(comanda_id, produto_id, quantidade, valor_unitario, funcionario_id) " +
            " VALUES (@idComanda, @idProduto, @quantidade, @valorUnitario, @idFuncionario)";
            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
        }

        public DataTable ListaItensComanda(ComandaProdutos comandaProdutos)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetros (@campo e valor)
            var idComanda = comando.CreateParameter();
            idComanda.ParameterName = "@idComanda";
            idComanda.Value = comandaProdutos.IdComanda;
            comando.Parameters.Add(idComanda);
            conexao.Open();
            comando.CommandText = @"" +
            "SELECT cp.id_comanda_produto AS ID, p.nome AS Nome, cp.quantidade AS Quantidade, cp.valor_unitario AS Unitário, f.nome AS Funcionário " +
            " FROM tb_comanda_produto cp " +
            " INNER JOIN tb_produto p ON cp.produto_id = p.id_produto " +
            " INNER JOIN tb_funcionario f ON cp.funcionario_id = f.id_funcionario " +
            " WHERE cp.comanda_id = @idComanda;";
            //Executa o script na conexão e retorna as linhas afetadas.
            var sdr = comando.ExecuteReader();
            DataTable linhas = new();
            linhas.Load(sdr);
            return linhas;
        }

        public void EditaItemComanda(ComandaProdutos comandaProdutos)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
                                           //Adiciona parâmetros (@campo e valor)
            var idComandaProduto = comando.CreateParameter();
            idComandaProduto.ParameterName = "@idComandaProduto";
            idComandaProduto.Value = comandaProdutos.IdComandaProduto;
            comando.Parameters.Add(idComandaProduto);
            var quantidade = comando.CreateParameter();
            quantidade.ParameterName = "@quantidade";
            quantidade.Value = comandaProdutos.Quantidade;
            comando.Parameters.Add(quantidade);
            var idFuncionario = comando.CreateParameter();
            idFuncionario.ParameterName = "@idFuncionario";
            idFuncionario.Value = comandaProdutos.IdFuncionario;
            comando.Parameters.Add(idFuncionario);
            conexao.Open();
            if (comandaProdutos.Quantidade == 0)
            {
                comando.CommandText = @"DELETE FROM tb_comanda_produto WHERE id_comanda_produto = @idComandaProduto";
            }
            else
            {
                comando.CommandText = @"UPDATE tb_comanda_produto SET quantidade = @quantidade, funcionario_id = @idFuncionario WHERE id_comanda_produto = @idComandaProduto";
            }
            //Executa o script na conexão e retorna o número de linhas afetadas.
            var linhas = comando.ExecuteNonQuery();
        }
    }
}