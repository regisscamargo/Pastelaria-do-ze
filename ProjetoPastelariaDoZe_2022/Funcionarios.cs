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
    public partial class Funcionarios : Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// 

        private readonly FuncionarioDAO dao;
    /// <summary>
    /// 
    /// </summary>
        public Funcionarios()
        {
            InitializeComponent();
            labelNomeFuncionario.Text = Properties.Resources.ResourceManager.GetString("labelNomeFuncionario");
            labelidFuncionario.Text = Properties.Resources.ResourceManager.GetString("labelidFuncionario");
            labelMatriculaFuncionario.Text = Properties.Resources.ResourceManager.GetString("labelMatriculaFuncionario");
            labelCpfFuncionario.Text = Properties.Resources.ResourceManager.GetString("labelCpfFuncionario");
            labelSenhaFuncionario.Text = Properties.Resources.ResourceManager.GetString("labelSenhaFuncionario");
            labelReSenhaFuncionario.Text = Properties.Resources.ResourceManager.GetString("labelReSenhaFuncionario");
            labelTelefoneFuncionario.Text = Properties.Resources.ResourceManager.GetString("labelTelefoneFuncionario");
            buttonVoltarFunc.Text = Properties.Resources.ResourceManager.GetString("buttonVoltarFunc");
            buttonConcluirFunc.Text = Properties.Resources.ResourceManager.GetString("buttonConcluirFunc");
            radioButtonAdm.Text = Properties.Resources.ResourceManager.GetString("radioButtonAdm");
            radioButtonBalcao.Text = Properties.Resources.ResourceManager.GetString("radioButtonBalcao");

        


            textBox1.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBox1.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            textBox2.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox2.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            textBox3.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox3.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            textBox4.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox4.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            textBox5.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox5.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            textBoxSenhaFunc.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxSenhaFunc.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            textBox7.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox7.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);


            buttonVoltarFunc.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            buttonVoltarFunc.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            buttonConcluirFunc.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            buttonConcluirFunc.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            this.KeyDown += new KeyEventHandler(ClassFuncoes.FormEventoKeyDown!);

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;


            dao = new FuncionarioDAO(provider, strConnection);
          

        }


            private void Funcionarios_Load(object sender, EventArgs e)
            {

            }

            private void textBox3_TextChanged(object sender, EventArgs e)
            {

            }

            private void buttonVoltarFunc_Click(object sender, EventArgs e)
            {
          
            this.Hide();
                Form f = new Controle_de_Estoque_do_Zé();
                f.FormClosed += (s, args) =>
                this.Close();
                f.Show();
            }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(funcionario);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBox1.Text = row[0].ToString();
                    textBox4.Text = row[1].ToString();
                    textBox2.Text = row[2].ToString();
                    textBox5.Text = row[3].ToString();
                    textBox3.Text = row[5].ToString();
                  

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
            var funcionario = new Funcionario
            {
                IdFuncionario = 0,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(funcionario);
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

        private void Funcionarios_FormClosing(object sender, FormClosingEventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConcluirFunc_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("O campo ID é obrigatório!");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("O campo CPF é obrigatório!");
                textBox2.Focus();
                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("O campo Matricula é obrigatório!");
                textBox3.Focus();
                return;
            }

            if (textBoxSenhaFunc.Text == "")
            {
                MessageBox.Show("O campo Senha é obrigatório!");
                textBoxSenhaFunc.Focus();
                return;
            }

            if (textBox7.Text == "")
            {
                MessageBox.Show("O campo Re-senha é obrigatório!");
                textBox7.Focus();
                return;
            }

            var funcionario = new Funcionario
            {
                IdFuncionario = 0,
                Nome = textBox4.Text,
                Cpf = textBox2.Text,
                Telefone = textBox5.Text,
                Senha = ClassFuncoes.Sha256Hash(textBoxSenhaFunc.Text),
                Matricula = textBox3.Text,
                Grupo = (radioButtonAdm.Checked) ? 1 : 2,
            };
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(funcionario);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            AtualizarTela();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAdm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelSenhaFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            var funcionario = new Funcionario
            {
                IdFuncionario = int.Parse(textBox1.Text),
                Nome = textBox4.Text,
                Cpf = textBox2.Text,
                Telefone = textBox5.Text, 
                Matricula = textBox3.Text,
                Grupo = (radioButtonAdm.Checked) ? 1 : 2,

            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.EditarDbProvider(funcionario);
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
            var funcionario = new Funcionario
            {
                IdFuncionario = int.Parse(textBox1.Text),
            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.ExcluirDbProvider(funcionario);
                MessageBox.Show("Dados excluidos com sucesso!");
              
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
    }
    }

