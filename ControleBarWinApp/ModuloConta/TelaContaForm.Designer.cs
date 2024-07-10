namespace ControleBar.WinApp.ModuloConta
{
    partial class TelaContaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaContaForm));
            cmbMesa = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            cmbGarcom = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            toolStrip1 = new ToolStrip();
            btnEditarPedido = new ToolStripButton();
            btnRemoverPedido = new ToolStripButton();
            listProdutos = new ListBox();
            btnAdicionar = new Button();
            numQtd = new NumericUpDown();
            label5 = new Label();
            cmbProduto = new ComboBox();
            label2 = new Label();
            label6 = new Label();
            lblTotal = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQtd).BeginInit();
            SuspendLayout();
            // 
            // cmbMesa
            // 
            cmbMesa.FormattingEnabled = true;
            cmbMesa.Location = new Point(430, 96);
            cmbMesa.Name = "cmbMesa";
            cmbMesa.Size = new Size(188, 28);
            cmbMesa.TabIndex = 36;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(373, 654);
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
            btnCancelar.Location = new Point(504, 654);
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
            label4.Location = new Point(84, 49);
            label4.Name = "label4";
            label4.Size = new Size(32, 25);
            label4.TabIndex = 33;
            label4.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(352, 96);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 32;
            label3.Text = "Mesa:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(122, 50);
            txtId.Name = "txtId";
            txtId.Size = new Size(118, 27);
            txtId.TabIndex = 31;
            txtId.Text = "0";
            // 
            // cmbGarcom
            // 
            cmbGarcom.FormattingEnabled = true;
            cmbGarcom.Location = new Point(122, 96);
            cmbGarcom.Name = "cmbGarcom";
            cmbGarcom.Size = new Size(210, 28);
            cmbGarcom.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(34, 96);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 38;
            label1.Text = "Garçom:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(numQtd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbProduto);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(34, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(590, 432);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Pedidos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(toolStrip1);
            groupBox2.Controls.Add(listProdutos);
            groupBox2.Location = new Point(14, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(557, 332);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produtos";
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnEditarPedido, btnRemoverPedido });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip1.Location = new Point(3, 23);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(551, 55);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnEditarPedido
            // 
            btnEditarPedido.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnEditarPedido.Image = (Image)resources.GetObject("btnEditarPedido.Image");
            btnEditarPedido.ImageTransparentColor = Color.Magenta;
            btnEditarPedido.Name = "btnEditarPedido";
            btnEditarPedido.Size = new Size(52, 52);
            btnEditarPedido.Text = "Editar";
            // 
            // btnRemoverPedido
            // 
            btnRemoverPedido.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRemoverPedido.Image = (Image)resources.GetObject("btnRemoverPedido.Image");
            btnRemoverPedido.ImageTransparentColor = Color.Magenta;
            btnRemoverPedido.Name = "btnRemoverPedido";
            btnRemoverPedido.Size = new Size(72, 52);
            btnRemoverPedido.Text = "Remover";
            // 
            // listProdutos
            // 
            listProdutos.FormattingEnabled = true;
            listProdutos.Location = new Point(12, 97);
            listProdutos.Name = "listProdutos";
            listProdutos.Size = new Size(539, 224);
            listProdutos.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(464, 37);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(107, 29);
            btnAdicionar.TabIndex = 43;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // numQtd
            // 
            numQtd.Location = new Point(372, 38);
            numQtd.Name = "numQtd";
            numQtd.Size = new Size(72, 27);
            numQtd.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(318, 38);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 41;
            label5.Text = "Qtd:";
            // 
            // cmbProduto
            // 
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(104, 37);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(194, 28);
            cmbProduto.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(14, 40);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 40;
            label2.Text = "Produto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(34, 619);
            label6.Name = "label6";
            label6.Size = new Size(105, 25);
            label6.TabIndex = 40;
            label6.Text = "Valor Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotal.Location = new Point(145, 619);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 25);
            lblTotal.TabIndex = 41;
            lblTotal.Text = "0,00";
            // 
            // TelaContaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 715);
            Controls.Add(lblTotal);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(cmbGarcom);
            Controls.Add(cmbMesa);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtId);
            Name = "TelaContaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaContaForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQtd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMesa;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label4;
        private Label label3;
        private TextBox txtId;
        private ComboBox cmbGarcom;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ToolStrip toolStrip1;
        private ListBox listProdutos;
        private Button btnAdicionar;
        private NumericUpDown numQtd;
        private Label label5;
        private ComboBox cmbProduto;
        private Label label2;
        private ToolStripButton btnEditarPedido;
        private ToolStripButton btnRemoverPedido;
        private Label label6;
        private Label lblTotal;
    }
}