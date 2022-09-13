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
    public partial class Sair : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Sair()
        {
            InitializeComponent();
            mng.Text = Properties.Resources.ResourceManager.GetString("mng");


            button1Sair.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            button1Sair.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            button2Sair.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            button2Sair.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);


            button3Sair.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            button3Sair.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);



            button1Sair.Text = Properties.Resources.ResourceManager.GetString("button1Sair");
            button2Sair.Text = Properties.Resources.ResourceManager.GetString("button2Sair");
            button3Sair.Text = Properties.Resources.ResourceManager.GetString("button3Sair");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Controle_de_Estoque_do_Zé();
            f.FormClosed += (s, args) =>
            this.Close();
            f.Show();
        }

        private void Sair_Load(object sender, EventArgs e)
        {

        }

        private void mng_Click(object sender, EventArgs e)
        {

        }
    }
}
