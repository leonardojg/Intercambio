namespace Intercambio
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sucursalToolStripMenuItem,
            this.escolaToolStripMenuItem,
            this.escolaToolStripMenuItem1,
            this.alunoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sucursalToolStripMenuItem
            // 
            this.sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            this.sucursalToolStripMenuItem.Size = new System.Drawing.Size(102, 34);
            this.sucursalToolStripMenuItem.Text = "Sucursal";
            this.sucursalToolStripMenuItem.Click += new System.EventHandler(this.sucursalToolStripMenuItem_Click);
            // 
            // escolaToolStripMenuItem
            // 
            this.escolaToolStripMenuItem.Name = "escolaToolStripMenuItem";
            this.escolaToolStripMenuItem.Size = new System.Drawing.Size(78, 34);
            this.escolaToolStripMenuItem.Text = "Curso";
            // 
            // escolaToolStripMenuItem1
            // 
            this.escolaToolStripMenuItem1.Name = "escolaToolStripMenuItem1";
            this.escolaToolStripMenuItem1.Size = new System.Drawing.Size(83, 34);
            this.escolaToolStripMenuItem1.Text = "Escola";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(80, 34);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Sistema de Controle de Intercambio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escolaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
    }
}

