namespace ProjetoRestaurante
{
    partial class Principal
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
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.diaDaSemanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segundaFeiraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diaDaSemanaToolStripMenuItem,
            this.ToolStripMenuItemPedidos});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(800, 28);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // diaDaSemanaToolStripMenuItem
            // 
            this.diaDaSemanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.segundaFeiraToolStripMenuItem,
            this.ingredientesToolStripMenuItem});
            this.diaDaSemanaToolStripMenuItem.Name = "diaDaSemanaToolStripMenuItem";
            this.diaDaSemanaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.diaDaSemanaToolStripMenuItem.Text = "Pizzas";
            // 
            // segundaFeiraToolStripMenuItem
            // 
            this.segundaFeiraToolStripMenuItem.Name = "segundaFeiraToolStripMenuItem";
            this.segundaFeiraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.segundaFeiraToolStripMenuItem.Text = "Pizzas Prontas";
            this.segundaFeiraToolStripMenuItem.Click += new System.EventHandler(this.segundaFeiraToolStripMenuItem_Click);
            // 
            // ingredientesToolStripMenuItem
            // 
            this.ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            this.ingredientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ingredientesToolStripMenuItem.Text = "Montar Pizza";
            this.ingredientesToolStripMenuItem.Click += new System.EventHandler(this.ingredientesToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemPedidos
            // 
            this.ToolStripMenuItemPedidos.Name = "ToolStripMenuItemPedidos";
            this.ToolStripMenuItemPedidos.Size = new System.Drawing.Size(75, 24);
            this.ToolStripMenuItemPedidos.Text = "Pedidos";
            this.ToolStripMenuItemPedidos.Click += new System.EventHandler(this.ToolStripMenuItemPedidos_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.menuStripPrincipal);
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "Principal";
            this.Text = "Restaurante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem diaDaSemanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segundaFeiraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPedidos;
        private System.Windows.Forms.ToolStripMenuItem ingredientesToolStripMenuItem;
    }
}

