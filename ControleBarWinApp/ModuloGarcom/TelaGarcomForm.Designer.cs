namespace ControleBar.WinApp.ModuloGarcom
{
    partial class TelaGarcomForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(182, 115);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(100, 26);
            btnGravar.TabIndex = 28;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(287, 115);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 26);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(79, 28);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 27;
            label4.Text = "Id:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(125, 64);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(262, 23);
            txtNome.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(51, 63);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 25;
            label2.Text = "Nome:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(125, 29);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(104, 23);
            txtId.TabIndex = 23;
            txtId.Text = "0";
            // 
            // TelaGarcomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 164);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaGarcomForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaGarcomForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private Label label4;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtId;
    }
}