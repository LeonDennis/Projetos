namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxEditora = new System.Windows.Forms.TextBox();
            this.textBoxEdicao = new System.Windows.Forms.TextBox();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.botaoDeletar = new System.Windows.Forms.Button();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.botaoMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Editora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano edição: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Local: ";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(98, 20);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(213, 20);
            this.textBoxTitulo.TabIndex = 5;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(98, 62);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(213, 20);
            this.textBoxAutor.TabIndex = 6;
            this.textBoxAutor.TextChanged += new System.EventHandler(this.textBoxAutor_TextChanged);
            // 
            // textBoxEditora
            // 
            this.textBoxEditora.Location = new System.Drawing.Point(98, 103);
            this.textBoxEditora.Name = "textBoxEditora";
            this.textBoxEditora.Size = new System.Drawing.Size(213, 20);
            this.textBoxEditora.TabIndex = 7;
            this.textBoxEditora.TextChanged += new System.EventHandler(this.textBoxEditora_TextChanged);
            // 
            // textBoxEdicao
            // 
            this.textBoxEdicao.Location = new System.Drawing.Point(98, 144);
            this.textBoxEdicao.Name = "textBoxEdicao";
            this.textBoxEdicao.Size = new System.Drawing.Size(213, 20);
            this.textBoxEdicao.TabIndex = 8;
            this.textBoxEdicao.TextChanged += new System.EventHandler(this.textBoxEdicao_TextChanged);
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(98, 185);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(213, 20);
            this.textBoxLocal.TabIndex = 9;
            this.textBoxLocal.TextChanged += new System.EventHandler(this.textBoxLocal_TextChanged);
            // 
            // botaoDeletar
            // 
            this.botaoDeletar.Location = new System.Drawing.Point(12, 252);
            this.botaoDeletar.Name = "botaoDeletar";
            this.botaoDeletar.Size = new System.Drawing.Size(75, 23);
            this.botaoDeletar.TabIndex = 10;
            this.botaoDeletar.Text = "Limpar";
            this.botaoDeletar.UseVisualStyleBackColor = true;
            this.botaoDeletar.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(126, 252);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(75, 23);
            this.botaoSalvar.TabIndex = 11;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // botaoMostrar
            // 
            this.botaoMostrar.Location = new System.Drawing.Point(236, 252);
            this.botaoMostrar.Name = "botaoMostrar";
            this.botaoMostrar.Size = new System.Drawing.Size(75, 23);
            this.botaoMostrar.TabIndex = 12;
            this.botaoMostrar.Text = "Mostrar";
            this.botaoMostrar.UseVisualStyleBackColor = true;
            this.botaoMostrar.Click += new System.EventHandler(this.botaoMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 287);
            this.Controls.Add(this.botaoMostrar);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.botaoDeletar);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.textBoxEdicao);
            this.Controls.Add(this.textBoxEditora);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxEditora;
        private System.Windows.Forms.TextBox textBoxEdicao;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.Button botaoDeletar;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.Button botaoMostrar;
    }
}

