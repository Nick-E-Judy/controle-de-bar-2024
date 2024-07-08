namespace ControleBar.WinApp.ModuloConta
{
    partial class ListagemContaControl
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
            listConta = new ListBox();
            SuspendLayout();
            // 
            // listConta
            // 
            listConta.Dock = DockStyle.Fill;
            listConta.FormattingEnabled = true;
            listConta.Location = new Point(0, 0);
            listConta.Name = "listConta";
            listConta.Size = new Size(652, 476);
            listConta.TabIndex = 0;
            // 
            // ListagemContaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listConta);
            Name = "ListagemContaControl";
            Size = new Size(652, 476);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listConta;
    }
}
