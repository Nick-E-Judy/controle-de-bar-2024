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
            cmbMesa = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // cmbMesa
            // 
            cmbMesa.FormattingEnabled = true;
            cmbMesa.Location = new Point(146, 147);
            cmbMesa.Name = "cmbMesa";
            cmbMesa.Size = new Size(296, 28);
            cmbMesa.TabIndex = 36;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(198, 255);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(114, 35);
            btnGravar.TabIndex = 34;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(329, 255);
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
            label4.Location = new Point(93, 45);
            label4.Name = "label4";
            label4.Size = new Size(32, 25);
            label4.TabIndex = 33;
            label4.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(64, 146);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 32;
            label3.Text = "Mesa:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(146, 46);
            txtId.Name = "txtId";
            txtId.Size = new Size(118, 27);
            txtId.TabIndex = 31;
            txtId.Text = "0";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(146, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(296, 28);
            comboBox1.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(43, 92);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 38;
            label1.Text = "Garçom:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(147, 199);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(296, 27);
            dateTimePicker1.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(53, 188);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 40;
            label2.Text = "Data de";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(49, 210);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 41;
            label5.Text = "Abertura:";
            // 
            // TelaContaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 326);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(cmbMesa);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtId);
            Name = "TelaContaForm";
            Text = "TelaContaForm";
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
        private ComboBox comboBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label5;
    }
}