namespace ControleBar.WinApp.ModuloMesa
{
    partial class TelaMesaForm
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
            txtNumero = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            cbOcupada = new CheckBox();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(207, 205);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(114, 35);
            btnGravar.TabIndex = 34;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(327, 205);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 35);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(89, 44);
            label4.Name = "label4";
            label4.Size = new Size(32, 25);
            label4.TabIndex = 33;
            label4.Text = "Id:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(142, 91);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(299, 27);
            txtNumero.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(57, 90);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 32;
            label2.Text = "Número:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(142, 45);
            txtId.Name = "txtId";
            txtId.Size = new Size(118, 27);
            txtId.TabIndex = 30;
            txtId.Text = "0";
            // 
            // cbOcupada
            // 
            cbOcupada.AutoSize = true;
            cbOcupada.Location = new Point(142, 134);
            cbOcupada.Name = "cbOcupada";
            cbOcupada.Size = new Size(130, 24);
            cbOcupada.TabIndex = 36;
            cbOcupada.Text = "Mesa Ocupada";
            cbOcupada.UseVisualStyleBackColor = true;
            // 
            // TelaMesaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 258);
            Controls.Add(cbOcupada);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(txtId);
            Name = "TelaMesaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaMesaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private Label label4;
        private TextBox txtNumero;
        private Label label2;
        private TextBox txtId;
        private CheckBox cbOcupada;
    }
}