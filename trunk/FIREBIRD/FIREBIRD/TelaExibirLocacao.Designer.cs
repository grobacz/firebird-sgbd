namespace FIREBIRD
{
    partial class TelaExibirLocacao
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
            this.lbFilmes = new System.Windows.Forms.ListBox();
            this.bFechar = new System.Windows.Forms.Button();
            this.lCodigo = new System.Windows.Forms.Label();
            this.lCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filmes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente:";
            // 
            // lbFilmes
            // 
            this.lbFilmes.FormattingEnabled = true;
            this.lbFilmes.Location = new System.Drawing.Point(15, 101);
            this.lbFilmes.Name = "lbFilmes";
            this.lbFilmes.Size = new System.Drawing.Size(257, 108);
            this.lbFilmes.TabIndex = 3;
            // 
            // bFechar
            // 
            this.bFechar.Location = new System.Drawing.Point(197, 227);
            this.bFechar.Name = "bFechar";
            this.bFechar.Size = new System.Drawing.Size(75, 23);
            this.bFechar.TabIndex = 4;
            this.bFechar.Text = "Fechar";
            this.bFechar.UseVisualStyleBackColor = true;
            this.bFechar.Click += new System.EventHandler(this.bFechar_Click);
            // 
            // lCodigo
            // 
            this.lCodigo.AutoSize = true;
            this.lCodigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCodigo.ForeColor = System.Drawing.Color.Maroon;
            this.lCodigo.Location = new System.Drawing.Point(55, 23);
            this.lCodigo.Name = "lCodigo";
            this.lCodigo.Size = new System.Drawing.Size(41, 13);
            this.lCodigo.TabIndex = 5;
            this.lCodigo.Text = "label4";
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCliente.ForeColor = System.Drawing.Color.Maroon;
            this.lCliente.Location = new System.Drawing.Point(55, 52);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(41, 13);
            this.lCliente.TabIndex = 6;
            this.lCliente.Text = "label5";
            // 
            // TelaExibirLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lCliente);
            this.Controls.Add(this.lCodigo);
            this.Controls.Add(this.bFechar);
            this.Controls.Add(this.lbFilmes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaExibirLocacao";
            this.Text = "TelaExibirLocacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbFilmes;
        private System.Windows.Forms.Button bFechar;
        private System.Windows.Forms.Label lCodigo;
        private System.Windows.Forms.Label lCliente;
    }
}