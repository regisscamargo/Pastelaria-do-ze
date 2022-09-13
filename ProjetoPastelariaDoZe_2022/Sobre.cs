using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPastelariaDoZe_2022

{
    /// <summary>
    /// 
    /// </summary>
    public partial class Sobre : Form
    {

        /// <summary>
        /// 
        /// </summary>
        public Sobre()
        {
            InitializeComponent();
            labelSobreCopyright.Text = Properties.Resources.ResourceManager.GetString("labelSobreCopyright");
            labelSobreVersao.Text = Properties.Resources.ResourceManager.GetString("labelSobreVersao");
            buttonSobre.Text = Properties.Resources.ResourceManager.GetString("buttonSobre");
            labelSobreNome.Text = Properties.Resources.ResourceManager.GetString("labelSobreNome");
            labelSobreCompanhia.Text = Properties.Resources.ResourceManager.GetString("labelSobreCompanhia");
            groupBoxSobreDescricao.Text = Properties.Resources.ResourceManager.GetString("groupBoxSobreDescricao");
        


            groupBoxSobreDescricao.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            groupBoxSobreDescricao.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            buttonSobre.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            buttonSobre.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            this.KeyDown += new KeyEventHandler(ClassFuncoes.FormEventoKeyDown!);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Controle_de_Estoque_do_Zé();
            f.FormClosed += (s, args) =>
            this.Close();
            f.Show();
        }

        private void Sobre_Load(object sender, EventArgs e)
        {

        }

        private void Sobre_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
