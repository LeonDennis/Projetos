namespace WindowsFormsApplication1
{
    partial class VeiculoIHM
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
            this.textVeiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextAno = new System.Windows.Forms.MaskedTextBox();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.botaoLimpa = new System.Windows.Forms.Button();
            this.botaoMostrar = new System.Windows.Forms.Button();
            this.comboComb = new System.Windows.Forms.ComboBox();
            this.textFabricante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textVeiculo
            // 
            this.textVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVeiculo.Location = new System.Drawing.Point(170, 31);
            this.textVeiculo.Name = "textVeiculo";
            this.textVeiculo.Size = new System.Drawing.Size(176, 26);
            this.textVeiculo.TabIndex = 0;
            this.textVeiculo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veículo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fabricante: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Combustível: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ano/modelo: ";
            // 
            // maskedTextAno
            // 
            this.maskedTextAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextAno.Location = new System.Drawing.Point(170, 145);
            this.maskedTextAno.Mask = "0000";
            this.maskedTextAno.Name = "maskedTextAno";
            this.maskedTextAno.Size = new System.Drawing.Size(176, 26);
            this.maskedTextAno.TabIndex = 7;
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSalvar.Location = new System.Drawing.Point(17, 191);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(96, 38);
            this.botaoSalvar.TabIndex = 8;
            this.botaoSalvar.TabStop = false;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoLimpa
            // 
            this.botaoLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLimpa.Location = new System.Drawing.Point(136, 191);
            this.botaoLimpa.Name = "botaoLimpa";
            this.botaoLimpa.Size = new System.Drawing.Size(96, 38);
            this.botaoLimpa.TabIndex = 9;
            this.botaoLimpa.TabStop = false;
            this.botaoLimpa.Text = "Limpa";
            this.botaoLimpa.UseVisualStyleBackColor = true;
            this.botaoLimpa.Click += new System.EventHandler(this.botaoLimpa_Click);
            // 
            // botaoMostrar
            // 
            this.botaoMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMostrar.Location = new System.Drawing.Point(250, 191);
            this.botaoMostrar.Name = "botaoMostrar";
            this.botaoMostrar.Size = new System.Drawing.Size(96, 38);
            this.botaoMostrar.TabIndex = 10;
            this.botaoMostrar.TabStop = false;
            this.botaoMostrar.Text = "Mostrar";
            this.botaoMostrar.UseVisualStyleBackColor = true;
            this.botaoMostrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboComb
            // 
            this.comboComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboComb.FormattingEnabled = true;
            this.comboComb.Items.AddRange(new object[] {
            "Elétrico",
            "Etanol",
            "Gasolina",
            "Diesel"});
            this.comboComb.Location = new System.Drawing.Point(170, 111);
            this.comboComb.Name = "comboComb";
            this.comboComb.Size = new System.Drawing.Size(176, 28);
            this.comboComb.TabIndex = 5;
            // 
            // textFabricante
            // 
            this.textFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFabricante.Location = new System.Drawing.Point(170, 72);
            this.textFabricante.Name = "textFabricante";
            this.textFabricante.Size = new System.Drawing.Size(176, 26);
            this.textFabricante.TabIndex = 2;
            // 
            // VeiculoIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 245);
            this.Controls.Add(this.botaoMostrar);
            this.Controls.Add(this.botaoLimpa);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.maskedTextAno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboComb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFabricante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textVeiculo);
            this.Name = "VeiculoIHM";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextAno;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.Button botaoLimpa;
        private System.Windows.Forms.Button botaoMostrar;
        private System.Windows.Forms.ComboBox comboComb;
        private System.Windows.Forms.TextBox textFabricante;
    }
}

