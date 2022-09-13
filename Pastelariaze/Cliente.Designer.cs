namespace Pastelariaze
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Fiado = new System.Windows.Forms.CheckBox();
            this.dia = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.confirmar_senha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.valor_fiado = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.valorfiado = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SALVAR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nome
            // 
            resources.ApplyResources(this.nome, "nome");
            this.nome.Name = "nome";
            this.nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Fiado
            // 
            resources.ApplyResources(this.Fiado, "Fiado");
            this.Fiado.Name = "Fiado";
            this.Fiado.UseVisualStyleBackColor = true;
            this.Fiado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dia
            // 
            resources.ApplyResources(this.dia, "dia");
            this.dia.Name = "dia";
            this.dia.Click += new System.EventHandler(this.label6_Click);
            // 
            // senha
            // 
            resources.ApplyResources(this.senha, "senha");
            this.senha.Name = "senha";
            this.senha.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // confirmar_senha
            // 
            resources.ApplyResources(this.confirmar_senha, "confirmar_senha");
            this.confirmar_senha.Name = "confirmar_senha";
            this.confirmar_senha.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // valor_fiado
            // 
            resources.ApplyResources(this.valor_fiado, "valor_fiado");
            this.valor_fiado.Name = "valor_fiado";
            this.valor_fiado.Click += new System.EventHandler(this.valor_fiado_Click);
            // 
            // cpf
            // 
            resources.ApplyResources(this.cpf, "cpf");
            this.cpf.Name = "cpf";
            // 
            // telefone
            // 
            resources.ApplyResources(this.telefone, "telefone");
            this.telefone.Name = "telefone";
            this.telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // valorfiado
            // 
            resources.ApplyResources(this.valorfiado, "valorfiado");
            this.valorfiado.Name = "valorfiado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            // 
            // SALVAR
            // 
            resources.ApplyResources(this.SALVAR, "SALVAR");
            this.SALVAR.Name = "SALVAR";
            this.SALVAR.UseVisualStyleBackColor = true;
            this.SALVAR.Click += new System.EventHandler(this.SALVAR_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // Cliente
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SALVAR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.valor_fiado);
            this.Controls.Add(this.valorfiado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.confirmar_senha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.dia);
            this.Controls.Add(this.Fiado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nome);
            this.Name = "Cliente";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox nome;
        private Label label3;
        private TextBox id;
        private Label label4;
        private Label label5;
        private CheckBox Fiado;
        private Label dia;
        private TextBox senha;
        private Label label7;
        private TextBox confirmar_senha;
        private Label label8;
        private Label valor_fiado;
        private MaskedTextBox cpf;
        private MaskedTextBox telefone;
        private TextBox valorfiado;
        private DataGridView dataGridView1;
        private Button SALVAR;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
    }
}