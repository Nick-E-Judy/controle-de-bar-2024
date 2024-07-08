namespace ControleBar.WinApp.ModuloProduto
{
    partial class TelaProdutoForm
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
            txtId = new TextBox();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            label4 = new Label();
            numPreco = new NumericUpDown();
            btnGravar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numPreco).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(137, 37);
            txtId.Name = "txtId";
            txtId.Size = new Size(154, 27);
            txtId.TabIndex = 12;
            txtId.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(52, 134);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 18;
            label3.Text = "Preço:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(137, 84);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(299, 27);
            txtNome.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(52, 86);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 17;
            label2.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(87, 39);
            label4.Name = "label4";
            label4.Size = new Size(32, 25);
            label4.TabIndex = 19;
            label4.Text = "Id:";
            // 
            // numPreco
            // 
            numPreco.DecimalPlaces = 2;
            numPreco.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numPreco.Location = new Point(137, 136);
            numPreco.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numPreco.Name = "numPreco";
            numPreco.Size = new Size(154, 27);
            numPreco.TabIndex = 20;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(201, 194);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(114, 35);
            btnGravar.TabIndex = 21;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(322, 194);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 35);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaProdutoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 252);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(numPreco);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Name = "TelaProdutoForm";
            Text = "TelaProdutoForm";
            ((System.ComponentModel.ISupportInitialize)numPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label3;
        private TextBox txtNome;
        private Label label2;
        private Label label4;
        private NumericUpDown numPreco;
        private Button btnGravar;
        private Button btnCancelar;
    }
}