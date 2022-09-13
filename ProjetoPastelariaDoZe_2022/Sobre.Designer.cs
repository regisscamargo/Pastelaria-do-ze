namespace ProjetoPastelariaDoZe_2022
{
    partial class Sobre
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSobreNome = new System.Windows.Forms.Label();
            this.labelSobreVersao = new System.Windows.Forms.Label();
            this.labelSobreCompanhia = new System.Windows.Forms.Label();
            this.labelSobreCopyright = new System.Windows.Forms.Label();
            this.groupBoxSobreDescricao = new System.Windows.Forms.GroupBox();
            this.buttonSobre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelSobreNome
            // 
            this.labelSobreNome.AutoSize = true;
            this.labelSobreNome.Location = new System.Drawing.Point(230, 9);
            this.labelSobreNome.Name = "labelSobreNome";
            this.labelSobreNome.Size = new System.Drawing.Size(103, 15);
            this.labelSobreNome.TabIndex = 1;
            this.labelSobreNome.Text = "Nome do Produto";
            this.labelSobreNome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelSobreVersao
            // 
            this.labelSobreVersao.AutoSize = true;
            this.labelSobreVersao.Location = new System.Drawing.Point(230, 35);
            this.labelSobreVersao.Name = "labelSobreVersao";
            this.labelSobreVersao.Size = new System.Drawing.Size(41, 15);
            this.labelSobreVersao.TabIndex = 3;
            this.labelSobreVersao.Text = "Versão";
            // 
            // labelSobreCompanhia
            // 
            this.labelSobreCompanhia.AutoSize = true;
            this.labelSobreCompanhia.Location = new System.Drawing.Point(230, 93);
            this.labelSobreCompanhia.Name = "labelSobreCompanhia";
            this.labelSobreCompanhia.Size = new System.Drawing.Size(121, 15);
            this.labelSobreCompanhia.TabIndex = 4;
            this.labelSobreCompanhia.Text = "Nome da Companhia";
            // 
            // labelSobreCopyright
            // 
            this.labelSobreCopyright.AutoSize = true;
            this.labelSobreCopyright.Location = new System.Drawing.Point(230, 62);
            this.labelSobreCopyright.Name = "labelSobreCopyright";
            this.labelSobreCopyright.Size = new System.Drawing.Size(60, 15);
            this.labelSobreCopyright.TabIndex = 6;
            this.labelSobreCopyright.Text = "Copyright";
            // 
            // groupBoxSobreDescricao
            // 
            this.groupBoxSobreDescricao.Location = new System.Drawing.Point(230, 127);
            this.groupBoxSobreDescricao.Name = "groupBoxSobreDescricao";
            this.groupBoxSobreDescricao.Size = new System.Drawing.Size(200, 100);
            this.groupBoxSobreDescricao.TabIndex = 2;
            this.groupBoxSobreDescricao.TabStop = false;
            this.groupBoxSobreDescricao.Text = "Descrição";
            // 
            // buttonSobre
            // 
            this.buttonSobre.Location = new System.Drawing.Point(452, 190);
            this.buttonSobre.Name = "buttonSobre";
            this.buttonSobre.Size = new System.Drawing.Size(75, 23);
            this.buttonSobre.TabIndex = 1;
            this.buttonSobre.Text = "Voltar";
            this.buttonSobre.UseVisualStyleBackColor = true;
            this.buttonSobre.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 225);
            this.Controls.Add(this.buttonSobre);
            this.Controls.Add(this.groupBoxSobreDescricao);
            this.Controls.Add(this.labelSobreCopyright);
            this.Controls.Add(this.labelSobreCompanhia);
            this.Controls.Add(this.labelSobreVersao);
            this.Controls.Add(this.labelSobreNome);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Sobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sobre_FormClosing);
            this.Load += new System.EventHandler(this.Sobre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelSobreNome;
        private Label labelSobreVersao;
        private Label labelSobreCompanhia;
        private Label labelSobreCopyright;
        private GroupBox groupBoxSobreDescricao;
        private Button buttonSobre;
    }
}