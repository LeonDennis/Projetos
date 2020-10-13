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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.relatorio = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.previsualizacao = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // relatorio
            // 
            this.relatorio.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.relatorio_PrintPage);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(45, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(434, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Relatório com Printing Controls";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // previsualizacao
            // 
            this.previsualizacao.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.previsualizacao.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.previsualizacao.ClientSize = new System.Drawing.Size(400, 300);
            this.previsualizacao.Document = this.relatorio;
            this.previsualizacao.Enabled = true;
            this.previsualizacao.Icon = ((System.Drawing.Icon)(resources.GetObject("previsualizacao.Icon")));
            this.previsualizacao.Name = "previsualizacao";
            this.previsualizacao.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 153);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument relatorio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog previsualizacao;
    }
}

