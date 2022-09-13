using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Resources;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPastelariaDoZe_2022.DAO;
using System.Threading.Tasks;
using System.Data.Common;

namespace ProjetoPastelariaDoZe_2022
{
    /// <summary>
    /// 
    /// </summary>
    
    public partial class Produtos : Form
    {
        private readonly ProdutoDAO dao;
        /// <summary>
        /// 
        /// </summary>
        public Produtos()
        {
            InitializeComponent();
            labelNomeProdutos.Text = Properties.Resources.ResourceManager.GetString("labelNomeProdutos");
            labelidProdutos.Text = Properties.Resources.ResourceManager.GetString("labelidProdutos");
            labelValorProdutos.Text = Properties.Resources.ResourceManager.GetString("labelValorProdutos");
            labelDescricaoProdutos.Text = Properties.Resources.ResourceManager.GetString("labelDescricaoProdutos");
            labelTituloProdutos.Text = Properties.Resources.ResourceManager.GetString("labelTituloProdutos");
            buttonVoltarProd.Text = Properties.Resources.ResourceManager.GetString("buttonVoltarProd");
            buttonConcluirProd.Text = Properties.Resources.ResourceManager.GetString("buttonConcluirProd");

            textBox1.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBox1.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            textBox2.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox2.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            textBox3.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox3.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            richTextBox1.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            richTextBox1.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            buttonVoltarProd.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            buttonVoltarProd.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            buttonConcluirProd.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            buttonConcluirProd.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            dao = new ProdutoDAO(provider, strConnection);

            this.KeyDown += new KeyEventHandler(ClassFuncoes.FormEventoKeyDown!);

        }



        private void Produtos_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                IdProduto = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(produto);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBox1.Text = row[0].ToString();
                    textBox2.Text = row[1].ToString();
                    textBox3.Text = row[2].ToString();
                    richTextBox1.Text = row[3].ToString();
                    pictureBoxImagem.Image = ClassFuncoes.ConverteByteArrayParaImagem((byte[])row[4]);
                }
                textBox2.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                IdProduto = 0,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(produto);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonVoltarProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Controle_de_Estoque_do_Zé();
            f.FormClosed += (s, args) =>
            this.Close();
            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelTituloProdutos_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialogImagem.Title = "Imagem do produto";
            openFileDialogImagem.Filter = "Images (*.JPEG; *.BMP; *.JPG; *.GIF; *.PNG; *.)| *.JPEG; *.BMP; *.JPG; *.GIF; *.PNG; *.icon; *.JFIF";
                if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                //pega a imagem escolhida e adiciona na tela
                pictureBoxImagem.Image = Image.FromFile(openFileDialogImagem.FileName);
                //redimensiona a imagem
                pictureBoxImagem.Image = (Image)(new Bitmap(pictureBoxImagem.Image, new Size(130, 98)));
                //ajusta a visualização no tamanho do pictureBoxImagem na tela
                pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Produtos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var msg = Properties.Resources.ResourceManager.GetString("mng");
                var msg2 = Properties.Resources.ResourceManager.GetString("mng2");
                var result = MessageBox.Show(this, msg, msg2, MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void buttonConcluirProd_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                IdProduto = 0,
                Nome = textBox2.Text,
                Descricao = richTextBox1.Text,
                ValorUnitario = textBox3.Text,
                Foto = ClassFuncoes.ConverteImagemParaByteArray(pictureBoxImagem.Image),
            };
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(produto);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AtualizarTela();
           
        }

        private void dataGridViewDados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewDados.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridViewDados.Rows[dataGridViewDados.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                IdProduto = int.Parse(textBox1.Text),
                Nome = textBox2.Text,
                Descricao = richTextBox1.Text,
                ValorUnitario = textBox3.Text,
                Foto = ClassFuncoes.ConverteImagemParaByteArray(pictureBoxImagem.Image),
            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.EditarDbProvider(produto);
                MessageBox.Show("Dados editados com sucesso!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AtualizarTela();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                IdProduto = int.Parse(textBox1.Text),
            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.ExcluirDbProvider(produto);
                MessageBox.Show("Dados excluidos com sucesso!");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AtualizarTela();
        }
    }
}
