namespace ListaBDLivros
{
    partial class CadLivrosUIL
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonWord = new System.Windows.Forms.Button();
            this.buttonDelPastas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(448, 173);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Listar no ListBox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(224, 199);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(100, 23);
            this.buttonExcel.TabIndex = 2;
            this.buttonExcel.Text = "Listar no Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // buttonWord
            // 
            this.buttonWord.Location = new System.Drawing.Point(118, 199);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(100, 23);
            this.buttonWord.TabIndex = 3;
            this.buttonWord.Text = "Listar no Word";
            this.buttonWord.UseVisualStyleBackColor = true;
            this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // buttonDelPastas
            // 
            this.buttonDelPastas.Location = new System.Drawing.Point(330, 199);
            this.buttonDelPastas.Name = "buttonDelPastas";
            this.buttonDelPastas.Size = new System.Drawing.Size(130, 23);
            this.buttonDelPastas.TabIndex = 4;
            this.buttonDelPastas.Text = "Deletar pastas geradas";
            this.buttonDelPastas.UseVisualStyleBackColor = true;
            this.buttonDelPastas.Click += new System.EventHandler(this.buttonDelPastas_Click);
            // 
            // CadLivrosUIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 234);
            this.Controls.Add(this.buttonDelPastas);
            this.Controls.Add(this.buttonWord);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "CadLivrosUIL";
            this.Text = "CADASTRO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadLivrosUIL_FormClosed);
            this.Load += new System.EventHandler(this.CadLivrosUIL_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonWord;
        private System.Windows.Forms.Button buttonDelPastas;
    }
}

