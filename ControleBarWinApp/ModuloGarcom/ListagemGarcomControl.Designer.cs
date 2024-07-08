namespace ControleBar.WinApp.ModuloGarcom
{
    partial class ListagemGarcomControl
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
            listGarcom = new ListBox();
            SuspendLayout();
            // 
            // listGarcom
            // 
            listGarcom.Dock = DockStyle.Fill;
            listGarcom.FormattingEnabled = true;
            listGarcom.Location = new Point(0, 0);
            listGarcom.Name = "listGarcom";
            listGarcom.Size = new Size(462, 314);
            listGarcom.TabIndex = 0;
            // 
            // ListagemGarcomControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listGarcom);
            Name = "ListagemGarcomControl";
            Size = new Size(462, 314);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listGarcom;
    }
}
