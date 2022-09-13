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
    public partial class Iniciar : Form
    {
        public Iniciar()
        {
            InitializeComponent();
       
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            empregado funcionario = new empregado();
            {
                StartPosition = FormStartPosition.CenterScreen;
            };
            _ = funcionario.ShowDialog();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            {
                StartPosition = FormStartPosition.CenterScreen;
            };
            _ = cliente.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            produtos produtos = new produtos();
            {
                StartPosition = FormStartPosition.CenterScreen;
            };
            _ = produtos.ShowDialog();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            sobre sobre = new sobre();
            {
                StartPosition = FormStartPosition.CenterScreen;
            };
            _ = sobre.ShowDialog();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            config config = new config();
            {
                StartPosition = FormStartPosition.CenterScreen;
            };
            _ = config.ShowDialog();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgresult = MessageBox.Show("Desejar sair da aplicação?", "Confirmar!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgresult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuStripPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        
        }


        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void inicioToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        private void contextMenuStripBandeja_Opening(object sender, CancelEventArgs e)
        {
          
        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ButtonInicio_Click(object sender, EventArgs e)
        {

        }

        private void notifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
            notifyIconSystemTray.Visible = false;
            notifyIconSystemTray.ShowBalloonTip(1000);
        }

        private void s(object sender, MouseEventArgs e)
        {

        }
    }
}
