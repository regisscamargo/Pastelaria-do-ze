namespace ProjetoPastelariaDoZe_2022
{
    partial class Funcionarios
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
            this.components = new System.ComponentModel.Container();
            this.labelTituloFuncionario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonAdm = new System.Windows.Forms.RadioButton();
            this.labelidFuncionario = new System.Windows.Forms.Label();
            this.labelCpfFuncionario = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelMatriculaFuncionario = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelNomeFuncionario = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelTelefoneFuncionario = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.radioButtonBalcao = new System.Windows.Forms.RadioButton();
            this.labelSenhaFuncionario = new System.Windows.Forms.Label();
            this.textBoxSenhaFunc = new System.Windows.Forms.TextBox();
            this.labelReSenhaFuncionario = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonVoltarFunc = new System.Windows.Forms.Button();
            this.buttonConcluirFunc = new System.Windows.Forms.Button();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.funcionarioDAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDAOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloFuncionario
            // 
            this.labelTituloFuncionario.AutoSize = true;
            this.labelTituloFuncionario.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTituloFuncionario.Location = new System.Drawing.Point(267, 10);
            this.labelTituloFuncionario.Name = "labelTituloFuncionario";
            this.labelTituloFuncionario.Size = new System.Drawing.Size(276, 37);
            this.labelTituloFuncionario.TabIndex = 0;
            this.labelTituloFuncionario.Text = "Cadastrar Funcionário";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(12, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButtonAdm
            // 
            this.radioButtonAdm.AutoSize = true;
            this.radioButtonAdm.Location = new System.Drawing.Point(494, 268);
            this.radioButtonAdm.Name = "radioButtonAdm";
            this.radioButtonAdm.Size = new System.Drawing.Size(101, 19);
            this.radioButtonAdm.TabIndex = 99;
            this.radioButtonAdm.TabStop = true;
            this.radioButtonAdm.Text = "Administrador";
            this.radioButtonAdm.UseVisualStyleBackColor = true;
            this.radioButtonAdm.CheckedChanged += new System.EventHandler(this.radioButtonAdm_CheckedChanged);
            // 
            // labelidFuncionario
            // 
            this.labelidFuncionario.AutoSize = true;
            this.labelidFuncionario.Location = new System.Drawing.Point(12, 89);
            this.labelidFuncionario.Name = "labelidFuncionario";
            this.labelidFuncionario.Size = new System.Drawing.Size(21, 15);
            this.labelidFuncionario.TabIndex = 4;
            this.labelidFuncionario.Text = "ID:";
            // 
            // labelCpfFuncionario
            // 
            this.labelCpfFuncionario.AutoSize = true;
            this.labelCpfFuncionario.Location = new System.Drawing.Point(282, 236);
            this.labelCpfFuncionario.Name = "labelCpfFuncionario";
            this.labelCpfFuncionario.Size = new System.Drawing.Size(31, 15);
            this.labelCpfFuncionario.TabIndex = 6;
            this.labelCpfFuncionario.Text = "CPF:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(282, 264);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "___.___.___.-__";
            this.textBox2.Size = new System.Drawing.Size(160, 23);
            this.textBox2.TabIndex = 2;
            // 
            // labelMatriculaFuncionario
            // 
            this.labelMatriculaFuncionario.AutoSize = true;
            this.labelMatriculaFuncionario.Location = new System.Drawing.Point(494, 161);
            this.labelMatriculaFuncionario.Name = "labelMatriculaFuncionario";
            this.labelMatriculaFuncionario.Size = new System.Drawing.Size(60, 15);
            this.labelMatriculaFuncionario.TabIndex = 8;
            this.labelMatriculaFuncionario.Text = "Matricula:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(494, 179);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 23);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelNomeFuncionario
            // 
            this.labelNomeFuncionario.AutoSize = true;
            this.labelNomeFuncionario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNomeFuncionario.Location = new System.Drawing.Point(12, 151);
            this.labelNomeFuncionario.Name = "labelNomeFuncionario";
            this.labelNomeFuncionario.Size = new System.Drawing.Size(43, 15);
            this.labelNomeFuncionario.TabIndex = 10;
            this.labelNomeFuncionario.Text = "Nome:";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(12, 179);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(430, 23);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelTelefoneFuncionario
            // 
            this.labelTelefoneFuncionario.AutoSize = true;
            this.labelTelefoneFuncionario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTelefoneFuncionario.Location = new System.Drawing.Point(12, 236);
            this.labelTelefoneFuncionario.Name = "labelTelefoneFuncionario";
            this.labelTelefoneFuncionario.Size = new System.Drawing.Size(54, 15);
            this.labelTelefoneFuncionario.TabIndex = 12;
            this.labelTelefoneFuncionario.Text = "Telefone:";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(12, 264);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(246, 23);
            this.textBox5.TabIndex = 5;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // radioButtonBalcao
            // 
            this.radioButtonBalcao.AutoSize = true;
            this.radioButtonBalcao.Location = new System.Drawing.Point(645, 268);
            this.radioButtonBalcao.Name = "radioButtonBalcao";
            this.radioButtonBalcao.Size = new System.Drawing.Size(60, 19);
            this.radioButtonBalcao.TabIndex = 99;
            this.radioButtonBalcao.TabStop = true;
            this.radioButtonBalcao.Text = "Balcão";
            this.radioButtonBalcao.UseVisualStyleBackColor = true;
            // 
            // labelSenhaFuncionario
            // 
            this.labelSenhaFuncionario.AutoSize = true;
            this.labelSenhaFuncionario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSenhaFuncionario.Location = new System.Drawing.Point(12, 334);
            this.labelSenhaFuncionario.Name = "labelSenhaFuncionario";
            this.labelSenhaFuncionario.Size = new System.Drawing.Size(42, 15);
            this.labelSenhaFuncionario.TabIndex = 15;
            this.labelSenhaFuncionario.Text = "Senha:";
            this.labelSenhaFuncionario.Click += new System.EventHandler(this.labelSenhaFuncionario_Click);
            // 
            // textBoxSenhaFunc
            // 
            this.textBoxSenhaFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSenhaFunc.Location = new System.Drawing.Point(12, 362);
            this.textBoxSenhaFunc.Name = "textBoxSenhaFunc";
            this.textBoxSenhaFunc.Size = new System.Drawing.Size(246, 23);
            this.textBoxSenhaFunc.TabIndex = 6;
            // 
            // labelReSenhaFuncionario
            // 
            this.labelReSenhaFuncionario.AutoSize = true;
            this.labelReSenhaFuncionario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReSenhaFuncionario.Location = new System.Drawing.Point(12, 419);
            this.labelReSenhaFuncionario.Name = "labelReSenhaFuncionario";
            this.labelReSenhaFuncionario.Size = new System.Drawing.Size(60, 15);
            this.labelReSenhaFuncionario.TabIndex = 17;
            this.labelReSenhaFuncionario.Text = "Re-Senha:";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(12, 447);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(246, 23);
            this.textBox7.TabIndex = 7;
            // 
            // buttonVoltarFunc
            // 
            this.buttonVoltarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVoltarFunc.Location = new System.Drawing.Point(12, 490);
            this.buttonVoltarFunc.Name = "buttonVoltarFunc";
            this.buttonVoltarFunc.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltarFunc.TabIndex = 8;
            this.buttonVoltarFunc.Text = "Voltar";
            this.buttonVoltarFunc.UseVisualStyleBackColor = true;
            this.buttonVoltarFunc.Click += new System.EventHandler(this.buttonVoltarFunc_Click);
            // 
            // buttonConcluirFunc
            // 
            this.buttonConcluirFunc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConcluirFunc.Location = new System.Drawing.Point(126, 490);
            this.buttonConcluirFunc.Name = "buttonConcluirFunc";
            this.buttonConcluirFunc.Size = new System.Drawing.Size(75, 23);
            this.buttonConcluirFunc.TabIndex = 9;
            this.buttonConcluirFunc.Text = "Concluir";
            this.buttonConcluirFunc.UseVisualStyleBackColor = true;
            this.buttonConcluirFunc.Click += new System.EventHandler(this.buttonConcluirFunc_Click);
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AllowUserToAddRows = false;
            this.dataGridViewDados.AutoGenerateColumns = false;
            this.dataGridViewDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.DataSource = this.funcionarioDAOBindingSource;
            this.dataGridViewDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDados.Location = new System.Drawing.Point(863, 12);
            this.dataGridViewDados.MultiSelect = false;
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.RowTemplate.Height = 25;
            this.dataGridViewDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDados.Size = new System.Drawing.Size(405, 458);
            this.dataGridViewDados.TabIndex = 100;
            this.dataGridViewDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewDados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewDados_MouseDoubleClick);
            // 
            // funcionarioDAOBindingSource
            // 
            this.funcionarioDAOBindingSource.DataSource = typeof(ProjetoPastelariaDoZe_2022.DAO.FuncionarioDAO);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // buttonEditar
            // 
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditar.Location = new System.Drawing.Point(863, 490);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 101;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1193, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 102;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 524);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dataGridViewDados);
            this.Controls.Add(this.buttonConcluirFunc);
            this.Controls.Add(this.buttonVoltarFunc);
            this.Controls.Add(this.labelReSenhaFuncionario);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.labelSenhaFuncionario);
            this.Controls.Add(this.textBoxSenhaFunc);
            this.Controls.Add(this.radioButtonBalcao);
            this.Controls.Add(this.labelTelefoneFuncionario);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.labelNomeFuncionario);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelMatriculaFuncionario);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelCpfFuncionario);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelidFuncionario);
            this.Controls.Add(this.radioButtonAdm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTituloFuncionario);
            this.KeyPreview = true;
            this.Name = "Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Funcionarios_FormClosing);
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDAOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTituloFuncionario;
        private TextBox textBox1;
        private RadioButton radioButtonAdm;
        private Label labelidFuncionario;
        private Label labelCpfFuncionario;
        private TextBox textBox2;
        private Label labelMatriculaFuncionario;
        private TextBox textBox3;
        private Label labelNomeFuncionario;
        private TextBox textBox4;
        private Label labelTelefoneFuncionario;
        private TextBox textBox5;
        private RadioButton radioButtonBalcao;
        private Label labelSenhaFuncionario;
        private TextBox textBoxSenhaFunc;
        private Label labelReSenhaFuncionario;
        private TextBox textBox7;
        private Button buttonVoltarFunc;
        private Button buttonConcluirFunc;
        private DataGridView dataGridViewDados;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private BindingSource funcionarioDAOBindingSource;
        private Button buttonEditar;
        private Button button2;
    }
}