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
using System.Resources;
using System.Globalization;

namespace ProjetoPastelariaDoZe_2022
{/// <summary>
/// 
/// </summary>
    public partial class Configurações : Form
    {
        /// <summary>
        /// 
        /// </summary>
      
        public Configurações()
        {
            InitializeComponent();
          
            labelTituloConfig.Text = Properties.Resources.ResourceManager.GetString("labelTituloConfig");
            labelLinguagemConfig.Text = Properties.Resources.ResourceManager.GetString("labelLinguagemConfig");
            labelCulturaConfig.Text = Properties.Resources.ResourceManager.GetString("labelCulturaConfig");
     
            buttonSalvarConfig.Text = Properties.Resources.ResourceManager.GetString("buttonSalvarConfig");
            checkBoxIdioma.Text = Properties.Resources.ResourceManager.GetString("checkBoxIdioma");

            comboBoxIdioma.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");


            comboBoxIdioma.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            comboBoxIdioma.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);


            buttonSalvarConfig.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            buttonSalvarConfig.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            this.KeyDown += new KeyEventHandler(ClassFuncoes.FormEventoKeyDown!);

            // busca os dados com nome BD
            ConnectionStringSettings connectionStringSettings =
            ConfigurationManager.ConnectionStrings["BD"];
            // obtém o providerName e atualiza em tela
            comboBoxProvider.Text = connectionStringSettings.ProviderName;
            // obtém a connectionString e atualiza em tela
            textBoxStringDeConexao.Text = connectionStringSettings.ConnectionString;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Configurações_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxIdioma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalvarConfig_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", comboBoxIdioma.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Close();
            _ = MessageBox.Show("Idioma/região alterada com sucesso! Reinicie a aplicação para aplicar o novo Idioma/região!");
            if (checkBoxIdioma.Checked) 
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void Configurações_FormClosing(object sender, FormClosingEventArgs e)
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

        private void buttonVoltarConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Controle_de_Estoque_do_Zé();
            f.FormClosed += (s, args) =>
            this.Close();
            f.Show();
        }

        private void labelLinguagemConfig_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvarBD_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //altera os valores de provider e da connectionStrings com nome BD
            config.ConnectionStrings.ConnectionStrings["BD"].ProviderName = comboBoxProvider.Text;
            config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString = textBoxStringDeConexao.Text;
            //salva as alterações
            config.Save(ConfigurationSaveMode.Modified, true);
            //recarrega os dados da seção especificada
            ConfigurationManager.RefreshSection("connectionStrings");
            //fecha a tela
            Close();
            //dispara msg para usuário
            _ = MessageBox.Show("Dados alterados com sucesso!");
        }

        private void comboBoxProvider_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
