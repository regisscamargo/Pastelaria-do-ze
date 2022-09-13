using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPastelariaDoZe_2022.DAO;
using System.Configuration;
using static ProjetoPastelariaDoZe_2022.DAO.ComandaDAO;

namespace ProjetoPastelaria
{
    public partial class Comandas : Form
    {
        private readonly ComandaDAO dao;
        private readonly ProdutoDAO daoProduto;
        public Comandas()
        {
            InitializeComponent();
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            dao = new ComandaDAO(provider, strConnection);
            daoProduto = new ProdutoDAO(provider, strConnection);
            AtualizaTelaAreaComandas();
            AtualizaTelaProduto();
        }

        private void buttonAbrirComanda_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var comanda = new Comanda
            {
                NumeroComanda = textBox1.Text,
                DataHora = DateTime.Now,
                StatusComanda = 0
            };
            try
            {
                // chama o método para inserir da nossa camada model
                /*
                *NÃO PODE TER OUTRA COMANDA COM MESMO NUMERO E STATUS 0
                * => SE TIVER DAR ALARME, SENÃO ABRIR
                */
                if (!dao.AbreNovaComanda(comanda))
                {
                    MessageBox.Show("ERRO!!! Comanda " + textBox1.Text + " já esta aberta!!!");
                }
                else
                {
                    MessageBox.Show("Comanda aberta com sucesso!");
                    AtualizaTelaAreaComandas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTelaItensComanda(int idComanda)
        {
            var comandaProdutos = new ComandaProdutos
            {
                IdComanda = idComanda
            };

            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.ListaItensComanda(comandaProdutos);

                // seta o data source com os dados retornados
                dataGridViewComandaItens.AutoGenerateColumns = true;
                dataGridViewComandaItens.DataSource = linhas;
                dataGridViewComandaItens.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AtualizaTelaProduto()
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                IdProduto = 0,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = daoProduto.SelectDbProvider(produto);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewProdutos.Columns.Clear();
                dataGridViewProdutos.AutoGenerateColumns = true;
                dataGridViewProdutos.DataSource = linhas;
                dataGridViewProdutos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AtualizaTelaAreaComandas()
        {
            var comanda = new Comanda
            {
                StatusComanda = 0
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.ListaComandas(comanda);
                // seta o data souce com os dados retornados
                dataGridViewComandas.AutoGenerateColumns = true;
                dataGridViewComandas.DataSource = linhas;
                dataGridViewComandas.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonComandaBuscar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                IdProduto = 0,
                Nome = textBoxBuscaProduto.Text,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = daoProduto.SelectDbProvider(produto);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewProdutos.Columns.Clear();
                dataGridViewProdutos.AutoGenerateColumns = true;
                dataGridViewProdutos.DataSource = linhas;
                dataGridViewProdutos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewComandas_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewComandas.SelectedCells.Count > 0)
            {
                //pega a linha selecionada
                DataGridViewRow selectedRow =

                dataGridViewComandas.Rows[dataGridViewComandas.SelectedCells[0].RowIndex];
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                int idComanda = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizarTelaItensComanda(idComanda);
            }
        }

        private void dataGridViewComandaItens_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedCells.Count > 0)
            {
                //pega o ID e o NUMERO da comanda selecionada
                DataGridViewRow selectedRowComanda = dataGridViewComandas.Rows[dataGridViewComandas.SelectedCells[0].RowIndex];
                int idComanda = Convert.ToInt32(selectedRowComanda.Cells[0].Value);
                int numeroComanda = Convert.ToInt32(selectedRowComanda.Cells[1].Value);
                //pega o ID, NOME, QUANTIDADE e VALOR do produto selecionado
                DataGridViewRow selectedRowComandaItens = dataGridViewComandaItens.Rows[dataGridViewComandaItens.SelectedCells[0].RowIndex];
                int idComandaProduto = Convert.ToInt32(selectedRowComandaItens.Cells[0].Value);
                string nomeProduto = Convert.ToString(selectedRowComandaItens.Cells[1].Value);
                string qtdaProduto = Convert.ToString(selectedRowComandaItens.Cells[2].Value);
                double valorProduto = Convert.ToDouble(selectedRowComandaItens.Cells[3].Value);
                //abrir tela confirmação e também para indicar a quantidade
                if (ClassFuncoes.InputBox("Editar " + nomeProduto + " na Comanda: " + numeroComanda, "Quantidade:", ref qtdaProduto) == DialogResult.OK)
                {
                    //Instância objeto
                    var comandaProdutos = new ComandaProdutos
                    {
                        IdComandaProduto = idComandaProduto,
                        Quantidade = Convert.ToInt32(qtdaProduto),
                        IdFuncionario = 1
                    };
                    try
                    {
                        // chama o método para inseir da nossa camada model
                        dao.EditaItemComanda(comandaProdutos);
                        AtualizarTelaItensComanda(idComanda);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dataGridViewProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedCells.Count > 0)
            {
                //pega o ID e o NUMERO da comanda selecionada
                DataGridViewRow selectedRowComanda = dataGridViewComandas.Rows[dataGridViewComandas.SelectedCells[0].RowIndex];
                int idComanda = Convert.ToInt32(selectedRowComanda.Cells[0].Value);
                int numeroComanda = Convert.ToInt32(selectedRowComanda.Cells[1].Value);
                //pega o ID, NOME e VALOR do produto selecionado
                DataGridViewRow selectedRowProduto = dataGridViewProdutos.Rows[dataGridViewProdutos.SelectedCells[0].RowIndex];
                int idProduto = Convert.ToInt32(selectedRowProduto.Cells[0].Value);
                double valorProduto = Convert.ToDouble(selectedRowProduto.Cells[2].Value);
                string nomeProduto = Convert.ToString(selectedRowProduto.Cells[1].Value);
                //abrir tela confirmação e também para indicar a quantidade
                string value = "1";
                if (ClassFuncoes.InputBox("Adicionar " + nomeProduto + " na Comanda: " + numeroComanda, "Quantidade:", ref value) == DialogResult.OK)
                {
                    //Instância objeto
                    var comandaProdutos = new ComandaProdutos
                    {
                        IdComanda = idComanda,
                        IdProduto = idProduto,
                        Quantidade = Convert.ToInt32(value),
                        ValorUnitario = valorProduto,
                        IdFuncionario = 1
                    };
                    try
                    {
                        // chama o metodo para inseir da nossa camada model
                        dao.AddItemComanda(comandaProdutos);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}