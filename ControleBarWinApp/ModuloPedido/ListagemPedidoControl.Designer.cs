namespace ControleBar.WinApp.ModuloPedido
{
    partial class ListagemPedidoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listPedido = new ListBox();
            SuspendLayout();
            // 
            // listPedido
            // 
            listPedido.Dock = DockStyle.Fill;
            listPedido.FormattingEnabled = true;
            listPedido.Location = new Point(0, 0);
            listPedido.Name = "listPedido";
            listPedido.Size = new Size(744, 460);
            listPedido.TabIndex = 0;
            // 
            // ListagemPedidoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listPedido);
            Name = "ListagemPedidoControl";
            Size = new Size(744, 460);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listPedido;
    }
}
