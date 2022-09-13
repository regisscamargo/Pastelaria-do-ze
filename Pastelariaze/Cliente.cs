using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ProjetoPastelariaDoZe_2022.DAO;

namespace Pastelariaze
{
    public partial class Cliente : Form

    {


        private readonly ClienteDAO dao;
        ///private int buttonVoltar_Click;
        ///

        public Cliente()
        {
            InitializeComponent();

          
       

            nome.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            nome.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            cpf.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            cpf.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            id.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            id.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            telefone.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            telefone.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            senha.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            senha.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            confirmar_senha.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            confirmar_senha.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            valorfiado.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            valorfiado.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            dao = new ClienteDAO(provider, strConnection);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void valor_fiado_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridViewDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }


        private void SALVAR_Click(object sender, EventArgs e)
        {
            var Cliente = new Cliente
            {
                IdCliente = 0,
                Nome = nome.Text,
                Cpf = cpf.Text,
                Telefone = telefone.Text,
                Compra_fiado = textBox1.Text,
                Dia_fiado = valorfiado.Text,
                Senha = ClassFuncoes.Sha256Hash(senha.Text),

            };
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(Cliente);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            AtualizarTela();
        }


         public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                IdCliente = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(cliente);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    nome.Text = row[0].ToString();
                    cpf.Text = row[1].ToString();
                    telefone.Text = row[2].ToString();
                    senha.Text = row[3].ToString();
                    valorfiado.Text = row[4].ToString();
                    textBox1.Text = row[5].ToString();


                }
                nome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var Cliente = new Cliente

            {
                IdCliente = 0,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(Cliente);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = linhas;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            AtualizarTela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                IdCliente = int.Parse(nome.Text),
                Cpf = cpf.Text,
                Telefone = telefone.Text,
                Compra_fiado = textBox1.Text,
                Dia_fiado = valorfiado.Text,
                Senha = ClassFuncoes.Sha256Hash(senha.Text),

            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.EditarDbProvider(cliente);
                MessageBox.Show("Dados editados com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            AtualizarTela();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Cliente = new Cliente
            {
                IdCliente = 0,
                Nome = nome.Text,
                Cpf = cpf.Text,
                Telefone = telefone.Text,
                Compra_fiado = textBox1.Text,
                Dia_fiado = valorfiado.Text,
                Senha = ClassFuncoes.Sha256Hash(senha.Text),

            };
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(Cliente);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            AtualizarTela();
        }
    }
}
