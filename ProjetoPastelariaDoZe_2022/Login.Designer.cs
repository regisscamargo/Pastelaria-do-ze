namespace ProjetoPastelariaDoZe_2022
{
    /// <summary>
    /// 
    /// </summary>
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelUsuarioLogin = new System.Windows.Forms.Label();
            this.labelTituloLogin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelSenhaLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUsuarioLogin
            // 
            resources.ApplyResources(this.labelUsuarioLogin, "labelUsuarioLogin");
            this.labelUsuarioLogin.Name = "labelUsuarioLogin";
            this.labelUsuarioLogin.Click += new System.EventHandler(this.labelUsuarioLogin_Click);
            // 
            // labelTituloLogin
            // 
            resources.ApplyResources(this.labelTituloLogin, "labelTituloLogin");
            this.labelTituloLogin.Name = "labelTituloLogin";
            this.labelTituloLogin.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonLogin
            // 
            resources.ApplyResources(this.buttonLogin, "buttonLogin");
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelSenhaLogin
            // 
            resources.ApplyResources(this.labelSenhaLogin, "labelSenhaLogin");
            this.labelSenhaLogin.Name = "labelSenhaLogin";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelSenhaLogin);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTituloLogin);
            this.Controls.Add(this.labelUsuarioLogin);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelUsuarioLogin;
        private Label labelTituloLogin;
        private TextBox textBox1;
        private Button buttonLogin;
        private TextBox textBox2;
        private Label labelSenhaLogin;
    }
}