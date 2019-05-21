namespace TreinaWeb.CSharpAvancado.EstudoEventos
{
    partial class FrmGerenciadorLatidosCachorros
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
            this.btnLatir = new System.Windows.Forms.Button();
            this.pgrIntensidadeLatido = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnLatir
            // 
            this.btnLatir.Location = new System.Drawing.Point(140, 12);
            this.btnLatir.Name = "btnLatir";
            this.btnLatir.Size = new System.Drawing.Size(75, 23);
            this.btnLatir.TabIndex = 0;
            this.btnLatir.Text = "Latir!";
            this.btnLatir.UseVisualStyleBackColor = true;
            this.btnLatir.Click += new System.EventHandler(this.btnLatir_Click);
            // 
            // pgrIntensidadeLatido
            // 
            this.pgrIntensidadeLatido.Location = new System.Drawing.Point(13, 50);
            this.pgrIntensidadeLatido.Name = "pgrIntensidadeLatido";
            this.pgrIntensidadeLatido.Size = new System.Drawing.Size(339, 27);
            this.pgrIntensidadeLatido.TabIndex = 1;
            // 
            // FrmGerenciadorLatidosCachorros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 87);
            this.Controls.Add(this.pgrIntensidadeLatido);
            this.Controls.Add(this.btnLatir);
            this.Name = "FrmGerenciadorLatidosCachorros";
            this.Text = "Gerenciador de latidos de cachorros";
            this.Load += new System.EventHandler(this.FrmGerenciadorLatidosCachorros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLatir;
        private System.Windows.Forms.ProgressBar pgrIntensidadeLatido;
    }
}

