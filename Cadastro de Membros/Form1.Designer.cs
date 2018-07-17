namespace Cadastro_de_Membros
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Consulta = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.consultaMembroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Consulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // Consulta
            // 
            this.Consulta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaMembroToolStripMenuItem});
            this.Consulta.Name = "Consulta";
            this.Consulta.ShowCheckMargin = true;
            this.Consulta.Size = new System.Drawing.Size(193, 26);
            // 
            // consultaMembroToolStripMenuItem
            // 
            this.consultaMembroToolStripMenuItem.Name = "consultaMembroToolStripMenuItem";
            this.consultaMembroToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.consultaMembroToolStripMenuItem.Text = "Consulta Membro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Consulta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip Consulta;
        private System.Windows.Forms.ToolStripMenuItem consultaMembroToolStripMenuItem;
    }
}

