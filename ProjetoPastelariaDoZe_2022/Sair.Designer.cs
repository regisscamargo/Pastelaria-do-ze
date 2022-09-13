namespace ProjetoPastelariaDoZe_2022
{
    /// <summary>
    /// 
    /// </summary>
    partial class Sair
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
            this.button3Sair = new System.Windows.Forms.Button();
            this.button2Sair = new System.Windows.Forms.Button();
            this.button1Sair = new System.Windows.Forms.Button();
            this.mng = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3Sair
            // 
            this.button3Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3Sair.Location = new System.Drawing.Point(362, 49);
            this.button3Sair.Name = "button3Sair";
            this.button3Sair.Size = new System.Drawing.Size(158, 23);
            this.button3Sair.TabIndex = 2;
            this.button3Sair.Text = "Enviar para a bandeja";
            this.button3Sair.UseVisualStyleBackColor = true;
            // 
            // button2Sair
            // 
            this.button2Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2Sair.Location = new System.Drawing.Point(185, 49);
            this.button2Sair.Name = "button2Sair";
            this.button2Sair.Size = new System.Drawing.Size(158, 23);
            this.button2Sair.TabIndex = 3;
            this.button2Sair.Text = "Sair";
            this.button2Sair.UseVisualStyleBackColor = true;
            this.button2Sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1Sair
            // 
            this.button1Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Sair.Location = new System.Drawing.Point(12, 49);
            this.button1Sair.Name = "button1Sair";
            this.button1Sair.Size = new System.Drawing.Size(158, 23);
            this.button1Sair.TabIndex = 1;
            this.button1Sair.Text = "Continuar";
            this.button1Sair.UseVisualStyleBackColor = true;
            this.button1Sair.Click += new System.EventHandler(this.button3_Click);
            // 
            // mng
            // 
            this.mng.AutoSize = true;
            this.mng.Location = new System.Drawing.Point(12, 9);
            this.mng.Name = "mng";
            this.mng.Size = new System.Drawing.Size(46, 15);
            this.mng.TabIndex = 4;
            this.mng.Text = "Deseja?";
            this.mng.Click += new System.EventHandler(this.mng_Click);
            // 
            // Sair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 80);
            this.Controls.Add(this.mng);
            this.Controls.Add(this.button1Sair);
            this.Controls.Add(this.button2Sair);
            this.Controls.Add(this.button3Sair);
            this.Name = "Sair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sair";
            this.Load += new System.EventHandler(this.Sair_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button3Sair;
        private Button button2Sair;
        private Button button1Sair;
        private Label mng;
    }
}