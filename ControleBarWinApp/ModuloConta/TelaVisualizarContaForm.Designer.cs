namespace ControleBar.WinApp.ModuloConta
{
    partial class TelaVisualizarContaForm
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
            lblNumMesa = new Label();
            lblDataAbertura = new Label();
            lblStatusConta = new Label();
            groupBox1 = new GroupBox();
            listPedidos = new ListBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnCancelar = new Button();
            label1 = new Label();
            lblNomeGarcom = new Label();
            label5 = new Label();
            lblTotalConta = new Label();
            btnFecharConta = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNumMesa
            // 
            lblNumMesa.AutoSize = true;
            lblNumMesa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumMesa.Location = new Point(216, 151);
            lblNumMesa.Name = "lblNumMesa";
            lblNumMesa.Size = new Size(178, 25);
            lblNumMesa.TabIndex = 43;
            lblNumMesa.Text = "[Número da Mesa]";
            // 
            // lblDataAbertura
            // 
            lblDataAbertura.AutoSize = true;
            lblDataAbertura.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataAbertura.Location = new Point(216, 96);
            lblDataAbertura.Name = "lblDataAbertura";
            lblDataAbertura.Size = new Size(180, 25);
            lblDataAbertura.TabIndex = 42;
            lblDataAbertura.Text = "[Data de Abertura]";
            // 
            // lblStatusConta
            // 
            lblStatusConta.AutoSize = true;
            lblStatusConta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusConta.Location = new Point(216, 45);
            lblStatusConta.Name = "lblStatusConta";
            lblStatusConta.Size = new Size(139, 25);
            lblStatusConta.TabIndex = 41;
            lblStatusConta.Text = "[Status Conta]";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listPedidos);
            groupBox1.Font = new Font("Segoe UI", 11.25F);
            groupBox1.Location = new Point(45, 266);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(519, 339);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pedidos";
            // 
            // listPedidos
            // 
            listPedidos.FormattingEnabled = true;
            listPedidos.ItemHeight = 25;
            listPedidos.Location = new Point(11, 39);
            listPedidos.Name = "listPedidos";
            listPedidos.Size = new Size(497, 279);
            listPedidos.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(45, 96);
            label3.Name = "label3";
            label3.Size = new Size(165, 25);
            label3.TabIndex = 39;
            label3.Text = "Data de Abertura: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(139, 45);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 38;
            label2.Text = "Status: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(144, 151);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 37;
            label4.Text = "Mesa: ";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(449, 677);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 35);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(123, 205);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 44;
            label1.Text = "Garçom: ";
            // 
            // lblNomeGarcom
            // 
            lblNomeGarcom.AutoSize = true;
            lblNomeGarcom.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeGarcom.Location = new Point(216, 205);
            lblNomeGarcom.Name = "lblNomeGarcom";
            lblNomeGarcom.Size = new Size(184, 25);
            lblNomeGarcom.TabIndex = 45;
            lblNomeGarcom.Text = "[Nome do Garçom]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(68, 638);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 46;
            label5.Text = "Total da Conta: ";
            // 
            // lblTotalConta
            // 
            lblTotalConta.AutoSize = true;
            lblTotalConta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalConta.Location = new Point(216, 638);
            lblTotalConta.Name = "lblTotalConta";
            lblTotalConta.Size = new Size(154, 25);
            lblTotalConta.TabIndex = 47;
            lblTotalConta.Text = "[Total da Conta]";
            // 
            // btnFecharConta
            // 
            btnFecharConta.DialogResult = DialogResult.Cancel;
            btnFecharConta.Font = new Font("Segoe UI", 11.25F);
            btnFecharConta.Location = new Point(285, 677);
            btnFecharConta.Margin = new Padding(3, 4, 3, 4);
            btnFecharConta.Name = "btnFecharConta";
            btnFecharConta.Size = new Size(147, 35);
            btnFecharConta.TabIndex = 48;
            btnFecharConta.Text = " Fechar Conta";
            btnFecharConta.UseVisualStyleBackColor = true;
            btnFecharConta.Click += btnFecharConta_Click;
            // 
            // TelaVisualizarContaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 741);
            Controls.Add(btnFecharConta);
            Controls.Add(lblTotalConta);
            Controls.Add(label5);
            Controls.Add(lblNomeGarcom);
            Controls.Add(label1);
            Controls.Add(lblNumMesa);
            Controls.Add(lblDataAbertura);
            Controls.Add(lblStatusConta);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Name = "TelaVisualizarContaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaVisualizarContaForm";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumMesa;
        private Label lblDataAbertura;
        private Label lblStatusConta;
        private GroupBox groupBox1;
        private ListBox listPedidos;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnCancelar;
        private Label label1;
        private Label lblNomeGarcom;
        private Label label5;
        private Label lblTotalConta;
        private Button btnFecharConta;
    }
}