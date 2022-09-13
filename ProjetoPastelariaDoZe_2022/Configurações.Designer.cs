namespace ProjetoPastelariaDoZe_2022
{
    partial class Configurações
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
            this.labelTituloConfig = new System.Windows.Forms.Label();
            this.labelLinguagemConfig = new System.Windows.Forms.Label();
            this.comboBoxIdioma = new System.Windows.Forms.ComboBox();
            this.labelCulturaConfig = new System.Windows.Forms.Label();
            this.checkBoxIdioma = new System.Windows.Forms.CheckBox();
            this.buttonSalvarConfig = new System.Windows.Forms.Button();
            this.buttonVoltarConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.textBoxStringDeConexao = new System.Windows.Forms.TextBox();
            this.buttonSalvarBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTituloConfig
            // 
            this.labelTituloConfig.AutoSize = true;
            this.labelTituloConfig.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTituloConfig.Location = new System.Drawing.Point(406, 9);
            this.labelTituloConfig.Name = "labelTituloConfig";
            this.labelTituloConfig.Size = new System.Drawing.Size(187, 37);
            this.labelTituloConfig.TabIndex = 1;
            this.labelTituloConfig.Text = "Configurações";
            this.labelTituloConfig.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLinguagemConfig
            // 
            this.labelLinguagemConfig.AutoSize = true;
            this.labelLinguagemConfig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLinguagemConfig.Location = new System.Drawing.Point(35, 112);
            this.labelLinguagemConfig.Name = "labelLinguagemConfig";
            this.labelLinguagemConfig.Size = new System.Drawing.Size(159, 21);
            this.labelLinguagemConfig.TabIndex = 4;
            this.labelLinguagemConfig.Text = "Linguagem/Cultura";
            this.labelLinguagemConfig.Click += new System.EventHandler(this.labelLinguagemConfig_Click);
            // 
            // comboBoxIdioma
            // 
            this.comboBoxIdioma.FormattingEnabled = true;
            this.comboBoxIdioma.Items.AddRange(new object[] {
            "pt-BR",
            "en-US",
            "es"});
            this.comboBoxIdioma.Location = new System.Drawing.Point(152, 156);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(121, 23);
            this.comboBoxIdioma.TabIndex = 3;
            this.comboBoxIdioma.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelCulturaConfig
            // 
            this.labelCulturaConfig.AutoSize = true;
            this.labelCulturaConfig.Location = new System.Drawing.Point(35, 158);
            this.labelCulturaConfig.Name = "labelCulturaConfig";
            this.labelCulturaConfig.Size = new System.Drawing.Size(111, 15);
            this.labelCulturaConfig.TabIndex = 9;
            this.labelCulturaConfig.Text = "Linguagem/Cultura";
            // 
            // checkBoxIdioma
            // 
            this.checkBoxIdioma.AutoSize = true;
            this.checkBoxIdioma.Location = new System.Drawing.Point(279, 160);
            this.checkBoxIdioma.Name = "checkBoxIdioma";
            this.checkBoxIdioma.Size = new System.Drawing.Size(161, 19);
            this.checkBoxIdioma.TabIndex = 4;
            this.checkBoxIdioma.Text = "Reiniciar e aplicar idioma.";
            this.checkBoxIdioma.UseVisualStyleBackColor = true;
            this.checkBoxIdioma.CheckedChanged += new System.EventHandler(this.checkBoxIdioma_CheckedChanged);
            // 
            // buttonSalvarConfig
            // 
            this.buttonSalvarConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSalvarConfig.Location = new System.Drawing.Point(356, 312);
            this.buttonSalvarConfig.Name = "buttonSalvarConfig";
            this.buttonSalvarConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarConfig.TabIndex = 5;
            this.buttonSalvarConfig.Text = "Salvar";
            this.buttonSalvarConfig.UseVisualStyleBackColor = true;
            this.buttonSalvarConfig.Click += new System.EventHandler(this.buttonSalvarConfig_Click);
            // 
            // buttonVoltarConfig
            // 
            this.buttonVoltarConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVoltarConfig.Location = new System.Drawing.Point(35, 312);
            this.buttonVoltarConfig.Name = "buttonVoltarConfig";
            this.buttonVoltarConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltarConfig.TabIndex = 42;
            this.buttonVoltarConfig.Text = "Voltar";
            this.buttonVoltarConfig.UseVisualStyleBackColor = true;
            this.buttonVoltarConfig.Click += new System.EventHandler(this.buttonVoltarConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(620, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Banco de Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "String de Conexão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Provider";
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(620, 156);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(274, 23);
            this.comboBoxProvider.TabIndex = 46;
            this.comboBoxProvider.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvider_SelectedIndexChanged);
            // 
            // textBoxStringDeConexao
            // 
            this.textBoxStringDeConexao.BackColor = System.Drawing.Color.White;
            this.textBoxStringDeConexao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStringDeConexao.Location = new System.Drawing.Point(672, 221);
            this.textBoxStringDeConexao.Name = "textBoxStringDeConexao";
            this.textBoxStringDeConexao.Size = new System.Drawing.Size(222, 23);
            this.textBoxStringDeConexao.TabIndex = 47;
            // 
            // buttonSalvarBD
            // 
            this.buttonSalvarBD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSalvarBD.Location = new System.Drawing.Point(936, 312);
            this.buttonSalvarBD.Name = "buttonSalvarBD";
            this.buttonSalvarBD.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarBD.TabIndex = 48;
            this.buttonSalvarBD.Text = "Salvar";
            this.buttonSalvarBD.UseVisualStyleBackColor = true;
            this.buttonSalvarBD.Click += new System.EventHandler(this.buttonSalvarBD_Click);
            // 
            // Configurações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 347);
            this.Controls.Add(this.buttonSalvarBD);
            this.Controls.Add(this.textBoxStringDeConexao);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVoltarConfig);
            this.Controls.Add(this.buttonSalvarConfig);
            this.Controls.Add(this.checkBoxIdioma);
            this.Controls.Add(this.labelCulturaConfig);
            this.Controls.Add(this.comboBoxIdioma);
            this.Controls.Add(this.labelLinguagemConfig);
            this.Controls.Add(this.labelTituloConfig);
            this.KeyPreview = true;
            this.Name = "Configurações";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Configurações_FormClosing);
            this.Load += new System.EventHandler(this.Configurações_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTituloConfig;
        private Label labelLinguagemConfig;
        private ComboBox comboBoxIdioma;
        private Label labelCulturaConfig;
        private CheckBox checkBoxIdioma;
        private Button buttonSalvarConfig;
        private Button buttonVoltarConfig;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxProvider;
        private TextBox textBoxStringDeConexao;
        private Button buttonSalvarBD;
    }
}