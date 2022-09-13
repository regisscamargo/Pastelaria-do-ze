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
    public partial class Controle_de_Estoque_do_Zé : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Controle_de_Estoque_do_Zé()
        {
            InitializeComponent();
            labelTituloEstoque.Text = Properties.Resources.ResourceManager.GetString("labelTituloEstoque");
            buttonFuncEstoque.Text = Properties.Resources.ResourceManager.GetString("buttonFuncEstoque");
            buttonCadEstoque.Text = Properties.Resources.ResourceManager.GetString("buttonCadEstoque");
            buttonCliEstoque.Text = Properties.Resources.ResourceManager.GetString("buttonCliEstoque");
            buttonConfigEstoque.Text = Properties.Resources.ResourceManager.GetString("buttonConfigEstoque");
            buttonSobreEstoque.Text = Properties.Resources.ResourceManager.GetString("buttonSobreEstoque");
            


            buttonFuncEstoque.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            buttonFuncEstoque.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            buttonCliEstoque.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            buttonCliEstoque.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            buttonCadEstoque.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            buttonCadEstoque.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            buttonConfigEstoque.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            buttonConfigEstoque.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            buttonSobreEstoque.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            buttonSobreEstoque.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            this.KeyDown += new KeyEventHandler(ClassFuncoes.FormEventoKeyDown!);



            funcionáriosToolStripMenuItem.Click += new EventHandler(button1_Click!);
            cadastroDeClientesToolStripMenuItem.Click += new EventHandler(button2_Click!);
            cadastroProdutoToolStripMenuItem.Click += new EventHandler(button4_Click!);
            configuraçõesToolStripMenuItem.Click += new EventHandler(button3_Click!);
            sobreToolStripMenuItem.Click += new EventHandler(button5_Click!);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Clientes();
            f.FormClosed += (s, args) =>
            this.Close();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Funcionarios();
            f.FormClosed += (s, args) =>
            this.Close();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Produtos();
            f.FormClosed += (s, args) =>
            this.Close();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Configurações();
            f.FormClosed += (s, args) =>
            this.Close();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Sobre();
            f.FormClosed += (s, args) =>
            this.Close();
            f.Show();
        }

        private void Controle_de_Estoque_do_Zé_Load(object sender, EventArgs e)
        {

        }

      

        private void contextMenuStripPrincipal_Opening(object sender, CancelEventArgs e)
        {

        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void controleDeEstoqueDoZéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Controle_de_Estoque_do_Zé();
            f.FormClosed += (s, args) =>
            this.Close();
            f.Show();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form1();
            f.FormClosed += (s, args) =>
            this.Close();
            f.Show();
        }

        private void Controle_de_Estoque_do_Zé_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)

            {
                this.Hide();
                Form f = new Sair();
                f.FormClosed += (s, args) =>
                this.Close();
                f.Show();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
            notifyIconSystemTray.Visible = false;
        }

        private void Controle_de_Estoque_do_Zé_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Sobre();
            f.FormClosed += (s, args) =>
            this.Close();
            f.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
