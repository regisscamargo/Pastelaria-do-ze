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
    /// 

    public partial class Clientes : Form
    {
        /// <summary>
        /// 
        /// </summary>
         private readonly ClienteDAO dao;
       
        /// <summary>
        /// 
        /// </summary>
        public Clientes()
        {
            InitializeComponent();

            labelNomeCliente.Text = Properties.Resources.ResourceManager.GetString("labelNomeCliente");
            labelidCliente.Text = Properties.Resources.ResourceManager.GetString("labelidCliente");
            labelTelefoneCliente.Text = Properties.Resources.ResourceManager.GetString("labelTelefoneCliente");
            labelCpfCliente.Text = Properties.Resources.ResourceManager.GetString("labelCpfCliente");
            labelSenhaCliente.Text = Properties.Resources.ResourceManager.GetString("labelSenhaCliente");
            labelReSenhaCliente.Text = Properties.Resources.ResourceManager.GetString("labelReSenhaCliente");
            labelMarcaFiadoCliente.Text = Properties.Resources.ResourceManager.GetString("labelMarcaFiadoCliente");
            labelDiaFiadoCliente.Text = Properties.Resources.ResourceManager.GetString("labelDiaFiadoCliente");
            buttonConcluirCliente.Text = Properties.Resources.ResourceManager.GetString("buttonConcluirCliente");
            buttonVoltarCliente.Text = Properties.Resources.ResourceManager.GetString("buttonVoltarCliente");



            textBox1.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBox1.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            textBox2.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox2.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            textBox4.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox4.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            textBox5.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox5.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            textBox6.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox6.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            textBox7.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox7.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            comboBox1.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            comboBox1.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            numericUpDown1.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            numericUpDown1.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);


            buttonVoltarCliente.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            buttonVoltarCliente.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            buttonConcluirCliente.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            buttonConcluirCliente.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            this.KeyDown += new KeyEventHandler(ClassFuncoes.FormEventoKeyDown!);


            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            dao = new ClienteDAO(provider, strConnection);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
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
                    textBox1.Text = row[0].ToString();
                    textBox4.Text = row[1].ToString();
                    textBox2.Text = row[2].ToString();
                    textBox5.Text = row[3].ToString();
                    comboBox1.Text = row[4].ToString();
                    numericUpDown1.Value = Convert.ToInt32(row[5].ToString());


                }
                textBox4.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Clientes_Load(object sender, EventArgs e)
        {

        }

    

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }


        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                IdCliente = 0,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(cliente);
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

        private void buttonVoltarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Controle_de_Estoque_do_Zé();
            f.FormClosed += (s, args) =>
            this.Close();
            f.Show();
        }

        private void Clientes_FormClosing(object sender, FormClosingEventArgs e)
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

        private void buttonConcluirCliente_Click(object sender, EventArgs e)
        {
            var Cliente = new Cliente
            {
                IdCliente = 0,
                Nome = textBox4.Text,
                Cpf = textBox2.Text,
                Telefone = textBox5.Text,
                Compra_fiado = comboBox1.Text,
                Dia_fiado = numericUpDown1.Text,
                Senha = ClassFuncoes.Sha256Hash(textBox6.Text),

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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            var cliente = new Cliente
            {
                IdCliente = int.Parse(textBox1.Text),
                Nome = textBox4.Text,
                Cpf = textBox2.Text,
                Telefone = textBox5.Text,
                Compra_fiado = comboBox1.Text,
                Dia_fiado = numericUpDown1.Text,

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

        private void button2_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                IdCliente = int.Parse(textBox1.Text),
            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.ExcluirDbProvider(cliente);
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
