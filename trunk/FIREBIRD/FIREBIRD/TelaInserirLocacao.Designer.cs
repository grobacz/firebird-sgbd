namespace FIREBIRD
{
    partial class TelaInserirLocacao
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
            this.lbTodosFilmes = new System.Windows.Forms.ListBox();
            this.lbFilmesLocar = new System.Windows.Forms.ListBox();
            this.bSetaAdd = new System.Windows.Forms.Button();
            this.bSetaRemover = new System.Windows.Forms.Button();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.lCliente = new System.Windows.Forms.Label();
            this.bInserirLocacao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTodosFilmes
            // 
            this.lbTodosFilmes.FormattingEnabled = true;
            this.lbTodosFilmes.Location = new System.Drawing.Point(12, 81);
            this.lbTodosFilmes.Name = "lbTodosFilmes";
            this.lbTodosFilmes.Size = new System.Drawing.Size(204, 199);
            this.lbTodosFilmes.TabIndex = 0;
            // 
            // lbFilmesLocar
            // 
            this.lbFilmesLocar.FormattingEnabled = true;
            this.lbFilmesLocar.Location = new System.Drawing.Point(264, 81);
            this.lbFilmesLocar.Name = "lbFilmesLocar";
            this.lbFilmesLocar.Size = new System.Drawing.Size(204, 199);
            this.lbFilmesLocar.TabIndex = 1;
            // 
            // bSetaAdd
            // 
            this.bSetaAdd.Location = new System.Drawing.Point(222, 140);
            this.bSetaAdd.Name = "bSetaAdd";
            this.bSetaAdd.Size = new System.Drawing.Size(36, 23);
            this.bSetaAdd.TabIndex = 2;
            this.bSetaAdd.Text = ">>";
            this.bSetaAdd.UseVisualStyleBackColor = true;
            this.bSetaAdd.Click += new System.EventHandler(this.bSetaAdd_Click);
            // 
            // bSetaRemover
            // 
            this.bSetaRemover.Location = new System.Drawing.Point(222, 178);
            this.bSetaRemover.Name = "bSetaRemover";
            this.bSetaRemover.Size = new System.Drawing.Size(36, 23);
            this.bSetaRemover.TabIndex = 3;
            this.bSetaRemover.Text = "<<";
            this.bSetaRemover.UseVisualStyleBackColor = true;
            this.bSetaRemover.Click += new System.EventHandler(this.bSetaRemover_Click);
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(60, 23);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(408, 21);
            this.cbClientes.TabIndex = 4;
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.Location = new System.Drawing.Point(12, 26);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(42, 13);
            this.lCliente.TabIndex = 5;
            this.lCliente.Text = "Cliente:";
            // 
            // bInserirLocacao
            // 
            this.bInserirLocacao.Location = new System.Drawing.Point(359, 300);
            this.bInserirLocacao.Name = "bInserirLocacao";
            this.bInserirLocacao.Size = new System.Drawing.Size(109, 23);
            this.bInserirLocacao.TabIndex = 6;
            this.bInserirLocacao.Text = "Inserir Locação";
            this.bInserirLocacao.UseVisualStyleBackColor = true;
            this.bInserirLocacao.Click += new System.EventHandler(this.bInserirLocacao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "A locar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filmes disponíveis:";
            // 
            // TelaInserirLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bInserirLocacao);
            this.Controls.Add(this.lCliente);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.bSetaRemover);
            this.Controls.Add(this.bSetaAdd);
            this.Controls.Add(this.lbFilmesLocar);
            this.Controls.Add(this.lbTodosFilmes);
            this.Name = "TelaInserirLocacao";
            this.Text = "TelaInserirLocacao";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaInserirLocacao_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTodosFilmes;
        private System.Windows.Forms.ListBox lbFilmesLocar;
        private System.Windows.Forms.Button bSetaAdd;
        private System.Windows.Forms.Button bSetaRemover;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.Button bInserirLocacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}