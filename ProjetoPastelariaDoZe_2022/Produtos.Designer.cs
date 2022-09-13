namespace ProjetoPastelariaDoZe_2022
{
    partial class Produtos
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
            this.labelValorProdutos = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelidProdutos = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTituloProdutos = new System.Windows.Forms.Label();
            this.labelNomeProdutos = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelDescricaoProdutos = new System.Windows.Forms.Label();
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.buttonVoltarProd = new System.Windows.Forms.Button();
            this.buttonConcluirProd = new System.Windows.Forms.Button();
            this.openFileDialogImagem = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.produtoDAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDAOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelValorProdutos
            // 
            this.labelValorProdutos.AutoSize = true;
            this.labelValorProdutos.Location = new System.Drawing.Point(522, 101);
            this.labelValorProdutos.Name = "labelValorProdutos";
            this.labelValorProdutos.Size = new System.Drawing.Size(36, 15);
            this.labelValorProdutos.TabIndex = 27;
            this.labelValorProdutos.Text = "Valor:";
            // 
            // textBox3
            // 
            this.textBox3.AccessibleDescription = "";
            this.textBox3.AccessibleName = "";
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(564, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 23);
            this.textBox3.TabIndex = 3;
            this.textBox3.Tag = "";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(208, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 23);
            this.textBox2.TabIndex = 2;
            // 
            // labelidProdutos
            // 
            this.labelidProdutos.AutoSize = true;
            this.labelidProdutos.Location = new System.Drawing.Point(30, 101);
            this.labelidProdutos.Name = "labelidProdutos";
            this.labelidProdutos.Size = new System.Drawing.Size(21, 15);
            this.labelidProdutos.TabIndex = 23;
            this.labelidProdutos.Text = "ID:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(57, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelTituloProdutos
            // 
            this.labelTituloProdutos.AutoSize = true;
            this.labelTituloProdutos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTituloProdutos.Location = new System.Drawing.Point(315, 9);
            this.labelTituloProdutos.Name = "labelTituloProdutos";
            this.labelTituloProdutos.Size = new System.Drawing.Size(174, 25);
            this.labelTituloProdutos.TabIndex = 19;
            this.labelTituloProdutos.Text = "Cadastrar Produtos";
            this.labelTituloProdutos.Click += new System.EventHandler(this.labelTituloProdutos_Click);
            // 
            // labelNomeProdutos
            // 
            this.labelNomeProdutos.AutoSize = true;
            this.labelNomeProdutos.Location = new System.Drawing.Point(159, 101);
            this.labelNomeProdutos.Name = "labelNomeProdutos";
            this.labelNomeProdutos.Size = new System.Drawing.Size(43, 15);
            this.labelNomeProdutos.TabIndex = 38;
            this.labelNomeProdutos.Text = "Nome:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 207);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(343, 129);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // labelDescricaoProdutos
            // 
            this.labelDescricaoProdutos.AutoSize = true;
            this.labelDescricaoProdutos.Location = new System.Drawing.Point(30, 189);
            this.labelDescricaoProdutos.Name = "labelDescricaoProdutos";
            this.labelDescricaoProdutos.Size = new System.Drawing.Size(61, 15);
            this.labelDescricaoProdutos.TabIndex = 40;
            this.labelDescricaoProdutos.Text = "Descricao:";
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxImagem.Location = new System.Drawing.Point(414, 207);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(270, 217);
            this.pictureBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagem.TabIndex = 41;
            this.pictureBoxImagem.TabStop = false;
            this.pictureBoxImagem.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonVoltarProd
            // 
            this.buttonVoltarProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVoltarProd.Location = new System.Drawing.Point(30, 443);
            this.buttonVoltarProd.Name = "buttonVoltarProd";
            this.buttonVoltarProd.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltarProd.TabIndex = 5;
            this.buttonVoltarProd.Text = "Voltar";
            this.buttonVoltarProd.UseVisualStyleBackColor = true;
            this.buttonVoltarProd.Click += new System.EventHandler(this.buttonVoltarProd_Click);
            // 
            // buttonConcluirProd
            // 
            this.buttonConcluirProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConcluirProd.Location = new System.Drawing.Point(159, 443);
            this.buttonConcluirProd.Name = "buttonConcluirProd";
            this.buttonConcluirProd.Size = new System.Drawing.Size(75, 23);
            this.buttonConcluirProd.TabIndex = 6;
            this.buttonConcluirProd.Text = "Concluir";
            this.buttonConcluirProd.UseVisualStyleBackColor = true;
            this.buttonConcluirProd.Click += new System.EventHandler(this.buttonConcluirProd_Click);
            // 
            // openFileDialogImagem
            // 
            this.openFileDialogImagem.FileName = "openFileDialog1";
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AllowUserToAddRows = false;
            this.dataGridViewDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDados.Location = new System.Drawing.Point(716, 22);
            this.dataGridViewDados.MultiSelect = false;
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.RowTemplate.Height = 25;
            this.dataGridViewDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDados.Size = new System.Drawing.Size(330, 402);
            this.dataGridViewDados.TabIndex = 45;
            this.dataGridViewDados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewDados_MouseDoubleClick);
            // 
            // produtoDAOBindingSource
            // 
            this.produtoDAOBindingSource.DataSource = typeof(ProjetoPastelariaDoZe_2022.DAO.ProdutoDAO);
            // 
            // buttonEditar
            // 
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditar.Location = new System.Drawing.Point(716, 443);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 46;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExcluir.Location = new System.Drawing.Point(971, 443);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 47;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "ADICIONAR IMAGEM";
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dataGridViewDados);
            this.Controls.Add(this.buttonConcluirProd);
            this.Controls.Add(this.buttonVoltarProd);
            this.Controls.Add(this.pictureBoxImagem);
            this.Controls.Add(this.labelDescricaoProdutos);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelNomeProdutos);
            this.Controls.Add(this.labelValorProdutos);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelidProdutos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTituloProdutos);
            this.KeyPreview = true;
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Produtos_FormClosing);
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDAOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelValorProdutos;
        private TextBox textBox3;
     
        private TextBox textBox2;
        private Label labelidProdutos;
        private TextBox textBox1;
        private Label labelTituloProdutos;
        private Label labelNomeProdutos;
        private RichTextBox richTextBox1;
        private Label labelDescricaoProdutos;
        private PictureBox pictureBoxImagem;
        private Button buttonVoltarProd;
        private Button buttonConcluirProd;
        private OpenFileDialog openFileDialogImagem;
        private DataGridView dataGridViewDados;
        private BindingSource produtoDAOBindingSource;
        private Button buttonEditar;
        private Button buttonExcluir;
        private Label label1;
    }
}