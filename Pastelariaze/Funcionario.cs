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

namespace Pastelariaze
{
    public partial class empregado : Form
    {

        private readonly FuncionarioDAO dao;
     

        public empregado()
        {
            InitializeComponent();
          
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            dao = new FuncionarioDAO(provider, strConnection);

        }

      

        private void IconSalvar_Click(object sender, EventArgs e)
        {
            
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = 0,
                Nome = textBoxName.Text,
                Cpf = maskedTextBox1.Text,
                Telefone = maskedTextTelefone.Text,
                Senha = textBox5.Text,
                Matricula = TextBoxMatricula.Text,
                Grupo = (radioButton1.Checked) ? 1 : 2,
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
            

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void empregado_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void CadastroFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            //obtém o form onde o componente gerou o evento
            Control x = (Control)sender;
            Form form = x.FindForm();
            //verifica se foi pressionado ENTER
            if (e.KeyCode == Keys.Enter)
            {
                //Obtém ou define um valor que indica se o evento de chave deve ser passado para o controle
                //subjacente.
                //true caso o evento chave não deva ser enviado ao controle; caso contrário, false
                //com isso evitamos o som de erro toda vez que pressionamos enter em algum campo
                e.SuppressKeyPress = true;
                //SendKeys.Send("{TAB}");
                form.SelectNextControl(form.ActiveControl, !e.Shift, true, true, true);
            }
            //verifica se foi pressionado ESC
            else if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show(" Deseja mesmo sair? ", "Mensage do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    form.Close();
                }
            }
        }
        private void CadastroFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Salvar alteração?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    //NADICA DE NAUDA
                }
                else
                {
                    //NADA
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = 0,
                Nome = textBoxName.Text,
                Cpf = maskedTextBox1.Text,
                Telefone = maskedTextTelefone.Text,
                Senha = ClassFuncoes.Sha256Hash(textBox6.Text),
                Matricula = TextBoxMatricula.Text,
                Grupo = (radioButton1.Checked) ? 1 : 2,
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
                    textBoxName.Text = row[0].ToString();
                    maskedTextBox1.Text = row[1].ToString();
                    maskedTextTelefone.Text = row[2].ToString();
                    textBox5.Text = row[3].ToString();
                    textBox3.Text = row[5].ToString();


                }
                textBoxName.Focus();
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

        private void SALVAR_Click(object sender, EventArgs e)
        {

            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = int.Parse(textBoxName.Text),
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

        private void button2_Click(object sender, EventArgs e)
        {
            var Funcionario = new Funcionario
            {
                IdCliente = int.Parse(textBox3.Text),
                Nome = textBoxName.Text,
                Cpf = maskedTextBox1.Text,
                Telefone = textBox5.Text,
                Grupo = (radioButton1.Checked) ? 1 : 2,

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
          

            

            var funcionario = new Funcionario
            {
                IdFuncionario = 0,
                Nome = textBoxName.Text,
                Cpf = maskedTextBox1.Text,
                Telefone = textBox5.Text,
                Senha = ClassFuncoes.Sha256Hash(textBox5.Text),
                Matricula = textBox3.Text,
                Grupo = (radioButton1.Checked) ? 1 : 2,
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
    }
}
