using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelariaze
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tb_usuario.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            tb_usuario.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            tb_senha.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            tb_senha.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            this.KeyDown += new KeyEventHandler(ClassFuncoes.FormEventoKeyDown!);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Iniciar menu = new();
            menu.FormClosed += (s, args) =>
            this.Close();
            menu.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_usuario_Enter(object sender, EventArgs e)
        {
            
        }

        private void tb_usuario_Leave(object sender, EventArgs e)
        {
            
        }

        private void tb_senha_Enter(object sender, EventArgs e)
        {
           
        }

        private void tb_senha_Leave(object sender, EventArgs e)
        {
            
        }

        private void bt_login_Enter(object sender, EventArgs e)
        {
        
        }

        private void tb_usuario_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_usuario_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
     

        }
    }
}
