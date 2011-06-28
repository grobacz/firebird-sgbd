namespace FIREBIRD
{
    partial class TelaInserirFilme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNomeFilme = new System.Windows.Forms.TextBox();
            this.cbGeneroFilme = new System.Windows.Forms.ComboBox();
            this.tbAnoLancamentoFilme = new System.Windows.Forms.TextBox();
            this.tbUrlImagemFilme = new System.Windows.Forms.TextBox();
            this.bBrowser = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.bInserirFilme = new System.Windows.Forms.Button();
            this.pictureBoxCapa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gênero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano Lançamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Imagem Capa:";
            // 
            // tbNomeFilme
            // 
            this.tbNomeFilme.Location = new System.Drawing.Point(59, 21);
            this.tbNomeFilme.Name = "tbNomeFilme";
            this.tbNomeFilme.Size = new System.Drawing.Size(303, 20);
            this.tbNomeFilme.TabIndex = 5;
            // 
            // cbGeneroFilme
            // 
            this.cbGeneroFilme.FormattingEnabled = true;
            this.cbGeneroFilme.Location = new System.Drawing.Point(62, 56);
            this.cbGeneroFilme.Name = "cbGeneroFilme";
            this.cbGeneroFilme.Size = new System.Drawing.Size(141, 21);
            this.cbGeneroFilme.TabIndex = 6;
            // 
            // tbAnoLancamentoFilme
            // 
            this.tbAnoLancamentoFilme.Location = new System.Drawing.Point(307, 56);
            this.tbAnoLancamentoFilme.MaxLength = 4;
            this.tbAnoLancamentoFilme.Name = "tbAnoLancamentoFilme";
            this.tbAnoLancamentoFilme.Size = new System.Drawing.Size(55, 20);
            this.tbAnoLancamentoFilme.TabIndex = 7;
            // 
            // tbUrlImagemFilme
            // 
            this.tbUrlImagemFilme.Location = new System.Drawing.Point(96, 95);
            this.tbUrlImagemFilme.Name = "tbUrlImagemFilme";
            this.tbUrlImagemFilme.Size = new System.Drawing.Size(226, 20);
            this.tbUrlImagemFilme.TabIndex = 8;
            // 
            // bBrowser
            // 
            this.bBrowser.Location = new System.Drawing.Point(328, 92);
            this.bBrowser.Name = "bBrowser";
            this.bBrowser.Size = new System.Drawing.Size(34, 23);
            this.bBrowser.TabIndex = 9;
            this.bBrowser.Text = "...";
            this.bBrowser.UseVisualStyleBackColor = true;
            this.bBrowser.Click += new System.EventHandler(this.bBrowser_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Localizar Imagem";
            // 
            // tbPreco
            // 
            this.tbPreco.Location = new System.Drawing.Point(59, 134);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(79, 20);
            this.tbPreco.TabIndex = 10;
            // 
            // bInserirFilme
            // 
            this.bInserirFilme.Location = new System.Drawing.Point(255, 132);
            this.bInserirFilme.Name = "bInserirFilme";
            this.bInserirFilme.Size = new System.Drawing.Size(107, 23);
            this.bInserirFilme.TabIndex = 11;
            this.bInserirFilme.Text = "Inserir Filme";
            this.bInserirFilme.UseVisualStyleBackColor = true;
            this.bInserirFilme.Click += new System.EventHandler(this.bInserirFilme_Click);
            // 
            // pictureBoxCapa
            // 
            this.pictureBoxCapa.Image = global::FIREBIRD.Properties.Resources.CapaImagem;
            this.pictureBoxCapa.ImageLocation = "";
            this.pictureBoxCapa.InitialImage = global::FIREBIRD.Properties.Resources.CapaImagem;
            this.pictureBoxCapa.Location = new System.Drawing.Point(384, 21);
            this.pictureBoxCapa.Name = "pictureBoxCapa";
            this.pictureBoxCapa.Size = new System.Drawing.Size(100, 133);
            this.pictureBoxCapa.TabIndex = 12;
            this.pictureBoxCapa.TabStop = false;
            // 
            // TelaInserirFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 170);
            this.Controls.Add(this.pictureBoxCapa);
            this.Controls.Add(this.bInserirFilme);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.bBrowser);
            this.Controls.Add(this.tbUrlImagemFilme);
            this.Controls.Add(this.tbAnoLancamentoFilme);
            this.Controls.Add(this.cbGeneroFilme);
            this.Controls.Add(this.tbNomeFilme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaInserirFilme";
            this.Text = "Inserir Filme";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNomeFilme;
        private System.Windows.Forms.ComboBox cbGeneroFilme;
        private System.Windows.Forms.TextBox tbAnoLancamentoFilme;
        private System.Windows.Forms.TextBox tbUrlImagemFilme;
        private System.Windows.Forms.Button bBrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbPreco;
        private System.Windows.Forms.Button bInserirFilme;
        private System.Windows.Forms.PictureBox pictureBoxCapa;
    }
}