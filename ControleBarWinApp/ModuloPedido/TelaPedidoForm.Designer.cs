namespace ControleBar.WinApp.ModuloPedido
{
    partial class TelaPedidoForm
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
            label1 = new Label();
            cmbProduto = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            numQtd = new NumericUpDown();
            btnAdicionar = new Button();
            groupBox1 = new GroupBox();
            listProdutos = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numQtd).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(47, 98);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 45;
            label1.Text = "Produto:";
            // 
            // cmbProduto
            // 
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(146, 99);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(291, 28);
            cmbProduto.TabIndex = 44;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(203, 461);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(114, 35);
            btnGravar.TabIndex = 42;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(323, 461);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 35);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(99, 47);
            label4.Name = "label4";
            label4.Size = new Size(32, 25);
            label4.TabIndex = 41;
            label4.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(84, 158);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 40;
            label3.Text = "Qtd:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(146, 48);
            txtId.Name = "txtId";
            txtId.Size = new Size(118, 27);
            txtId.TabIndex = 39;
            txtId.Text = "0";
            // 
            // numQtd
            // 
            numQtd.Location = new Point(146, 152);
            numQtd.Name = "numQtd";
            numQtd.Size = new Size(118, 27);
            numQtd.TabIndex = 46;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(298, 150);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(139, 33);
            btnAdicionar.TabIndex = 47;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listProdutos);
            groupBox1.Font = new Font("Segoe UI", 11.25F);
            groupBox1.Location = new Point(47, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 217);
            groupBox1.TabIndex = 48;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos do Pedido";
            // 
            // listProdutos
            // 
            listProdutos.FormattingEnabled = true;
            listProdutos.ItemHeight = 25;
            listProdutos.Location = new Point(6, 27);
            listProdutos.Name = "listProdutos";
            listProdutos.Size = new Size(378, 179);
            listProdutos.TabIndex = 0;
            // 
            // TelaPedidoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 526);
            Controls.Add(groupBox1);
            Controls.Add(btnAdicionar);
            Controls.Add(numQtd);
            Controls.Add(label1);
            Controls.Add(cmbProduto);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtId);
            Name = "TelaPedidoForm";
            Text = "TelaPedidoForm";
            ((System.ComponentModel.ISupportInitialize)numQtd).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbProduto;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label4;
        private Label label3;
        private TextBox txtId;
        private NumericUpDown numQtd;
        private Button btnAdicionar;
        private GroupBox groupBox1;
        private ListBox listProdutos;
    }
}