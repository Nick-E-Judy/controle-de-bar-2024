namespace ControleBar.WinApp.ModuloProduto
{
    partial class ListagemProdutoControl
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
            listProduto = new ListBox();
            SuspendLayout();
            // 
            // listProduto
            // 
            listProduto.Dock = DockStyle.Fill;
            listProduto.FormattingEnabled = true;
            listProduto.Location = new Point(0, 0);
            listProduto.Name = "listProduto";
            listProduto.Size = new Size(688, 492);
            listProduto.TabIndex = 0;
            // 
            // ListagemProdutoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listProduto);
            Name = "ListagemProdutoControl";
            Size = new Size(688, 492);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listProduto;
    }
}
