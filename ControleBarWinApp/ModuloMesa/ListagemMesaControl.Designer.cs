namespace ControleBar.WinApp.ModuloMesa
{
    partial class ListagemMesaControl
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
            listMesa = new ListBox();
            SuspendLayout();
            // 
            // listMesa
            // 
            listMesa.Dock = DockStyle.Fill;
            listMesa.FormattingEnabled = true;
            listMesa.Location = new Point(0, 0);
            listMesa.Name = "listMesa";
            listMesa.Size = new Size(625, 391);
            listMesa.TabIndex = 0;
            // 
            // ListagemMesaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listMesa);
            Name = "ListagemMesaControl";
            Size = new Size(625, 391);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listMesa;
    }
}
