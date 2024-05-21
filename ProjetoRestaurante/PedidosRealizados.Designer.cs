namespace ProjetoRestaurante
{
    partial class PedidosRealizados
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
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.ColumnNumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumeroPedido,
            this.ColumnCliente,
            this.ColumnFormaPagamento,
            this.ColumnData,
            this.ColumnTempo});
            this.dataGridViewPedido.Location = new System.Drawing.Point(12, 37);
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.RowHeadersWidth = 51;
            this.dataGridViewPedido.RowTemplate.Height = 24;
            this.dataGridViewPedido.Size = new System.Drawing.Size(1101, 377);
            this.dataGridViewPedido.TabIndex = 0;
            // 
            // ColumnNumeroPedido
            // 
            this.ColumnNumeroPedido.HeaderText = "Número";
            this.ColumnNumeroPedido.MinimumWidth = 6;
            this.ColumnNumeroPedido.Name = "ColumnNumeroPedido";
            this.ColumnNumeroPedido.Width = 125;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.HeaderText = "Cliente";
            this.ColumnCliente.MinimumWidth = 6;
            this.ColumnCliente.Name = "ColumnCliente";
            this.ColumnCliente.ReadOnly = true;
            this.ColumnCliente.Width = 300;
            // 
            // ColumnFormaPagamento
            // 
            this.ColumnFormaPagamento.HeaderText = "Forma de Pagamento";
            this.ColumnFormaPagamento.MinimumWidth = 6;
            this.ColumnFormaPagamento.Name = "ColumnFormaPagamento";
            this.ColumnFormaPagamento.ReadOnly = true;
            this.ColumnFormaPagamento.Width = 125;
            // 
            // ColumnData
            // 
            this.ColumnData.HeaderText = "Data";
            this.ColumnData.MinimumWidth = 6;
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.ReadOnly = true;
            this.ColumnData.Width = 125;
            // 
            // ColumnTempo
            // 
            this.ColumnTempo.HeaderText = "Tempo Realizaçao";
            this.ColumnTempo.MinimumWidth = 6;
            this.ColumnTempo.Name = "ColumnTempo";
            this.ColumnTempo.ReadOnly = true;
            this.ColumnTempo.Width = 125;
            // 
            // PedidosRealizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 450);
            this.Controls.Add(this.dataGridViewPedido);
            this.Name = "PedidosRealizados";
            this.Text = "PedidosRealizados";
            this.Load += new System.EventHandler(this.PedidosRealizados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTempo;
    }
}