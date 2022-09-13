namespace ProjetoPastelariaDoZe_2022
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// </summary>

        public Form1()
        {
            InitializeComponent();
            labelTituloLogin.Text = Properties.Resources.ResourceManager.GetString("labelTituloLogin");
            labelSenhaLogin.Text = Properties.Resources.ResourceManager.GetString("labelSenhaLogin");
            buttonLogin.Text = Properties.Resources.ResourceManager.GetString("buttonLogin");
            labelUsuarioLogin.Text = Properties.Resources.ResourceManager.GetString("labelUsuarioLogin");



            buttonLogin.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            buttonLogin.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            textBox1.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBox1.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);

            textBox2.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBox2.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            this.KeyDown += new KeyEventHandler(ClassFuncoes.FormEventoKeyDown!);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("O campo Usuário é obrigatório!");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("O campo Senha é obrigatório!");
                textBox2.Focus();
                return;
            }
            this.Hide();
            Form f = new Controle_de_Estoque_do_Zé();
            f.FormClosed += (s, args) =>
            this.Close();
            f.Show();

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelUsuarioLogin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}