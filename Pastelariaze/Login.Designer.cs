namespace Pastelariaze
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tb_usuario
            // 
            resources.ApplyResources(this.tb_usuario, "tb_usuario");
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.TabIndexChanged += new System.EventHandler(this.tb_usuario_TabIndexChanged);
            this.tb_usuario.TextChanged += new System.EventHandler(this.tb_usuario_TextChanged);
            this.tb_usuario.Enter += new System.EventHandler(this.tb_usuario_Enter);
            this.tb_usuario.Leave += new System.EventHandler(this.tb_usuario_Leave);
            // 
            // tb_senha
            // 
            resources.ApplyResources(this.tb_senha, "tb_senha");
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Enter += new System.EventHandler(this.tb_senha_Enter);
            this.tb_senha.Leave += new System.EventHandler(this.tb_senha_Leave);
            // 
            // bt_login
            // 
            resources.ApplyResources(this.bt_login, "bt_login");
            this.bt_login.Name = "bt_login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.button1_Click);
            this.bt_login.Enter += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pastelariaze.Properties.Resources.Sem_Título_1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_usuario;
        private TextBox tb_senha;
        private Button bt_login;
        private PictureBox pictureBox1;
    }
}