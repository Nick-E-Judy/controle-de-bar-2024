﻿namespace ControleBar.WinApp
{
    partial class TelaPrincipalForm
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
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            produtosMenuItem = new ToolStripMenuItem();
            garçonsMenuItem = new ToolStripMenuItem();
            contasMenuItem = new ToolStripMenuItem();
            pedidosMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            btnNovaMesa = new ToolStripButton();
            btnFecharConta = new ToolStripButton();
            lblTipoCadastro = new ToolStripLabel();
            pnlRegistros = new Panel();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            btnFaturamento = new ToolStripButton();
            btnPedido = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtosMenuItem, garçonsMenuItem, contasMenuItem, pedidosMenuItem });
            cadastrosToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(109, 29);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // produtosMenuItem
            // 
            produtosMenuItem.Name = "produtosMenuItem";
            produtosMenuItem.Size = new Size(224, 30);
            produtosMenuItem.Text = "Produtos";
            // 
            // garçonsMenuItem
            // 
            garçonsMenuItem.Name = "garçonsMenuItem";
            garçonsMenuItem.Size = new Size(224, 30);
            garçonsMenuItem.Text = "Garçons";
            // 
            // contasMenuItem
            // 
            contasMenuItem.Name = "contasMenuItem";
            contasMenuItem.Size = new Size(224, 30);
            contasMenuItem.Text = "Contas";
            // 
            // pedidosMenuItem
            // 
            pedidosMenuItem.Name = "pedidosMenuItem";
            pedidosMenuItem.Size = new Size(224, 30);
            pedidosMenuItem.Text = "Pedidos";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, btnFiltrar, btnNovaMesa, btnPedido, btnFaturamento, btnFecharConta, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 35);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Image = Properties.Resources.btnAdicionar;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(29, 24);
            btnAdicionar.Text = "Adicionar";
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.btnEditar;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(29, 24);
            btnEditar.Text = "Editar";
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = Properties.Resources.btnExcluir;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(29, 24);
            btnExcluir.Text = "Excluir";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Enabled = false;
            btnFiltrar.Image = Properties.Resources.btnFiltrar;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(29, 24);
            btnFiltrar.Text = "duplicar";
            btnFiltrar.ToolTipText = "Filtrar";
            // 
            // btnNovaMesa
            // 
            btnNovaMesa.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNovaMesa.Enabled = false;
            btnNovaMesa.Image = Properties.Resources.btnMesaBar;
            btnNovaMesa.ImageTransparentColor = Color.Magenta;
            btnNovaMesa.Name = "btnNovaMesa";
            btnNovaMesa.Size = new Size(29, 24);
            btnNovaMesa.Text = "Visualizar Testes";
            btnNovaMesa.ToolTipText = "Cadastrar Mesa";
            // 
            // btnFecharConta
            // 
            btnFecharConta.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFecharConta.Enabled = false;
            btnFecharConta.Image = Properties.Resources.btnFecharConta;
            btnFecharConta.ImageTransparentColor = Color.Magenta;
            btnFecharConta.Name = "btnFecharConta";
            btnFecharConta.Size = new Size(29, 24);
            btnFecharConta.Text = "Gerar PDF";
            btnFecharConta.ToolTipText = "Fechar Conta";
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(123, 24);
            lblTipoCadastro.Text = "Tipo de Cadastro";
            // 
            // pnlRegistros
            // 
            pnlRegistros.Location = new Point(0, 71);
            pnlRegistros.Margin = new Padding(3, 4, 3, 4);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(914, 529);
            pnlRegistros.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 574);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(914, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(175, 20);
            statusLabelPrincipal.Text = "Visualizando 0 registros...";
            // 
            // btnFaturamento
            // 
            btnFaturamento.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFaturamento.Enabled = false;
            btnFaturamento.Image = Properties.Resources.btnFaturamentoDiario;
            btnFaturamento.ImageTransparentColor = Color.Magenta;
            btnFaturamento.Name = "btnFaturamento";
            btnFaturamento.Size = new Size(29, 24);
            btnFaturamento.Text = "Gerar PDF";
            btnFaturamento.ToolTipText = "Faturamento Diário";
            // 
            // btnPedido
            // 
            btnPedido.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPedido.Enabled = false;
            btnPedido.Image = Properties.Resources.btnAdicionarPedido;
            btnPedido.ImageTransparentColor = Color.Magenta;
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(29, 24);
            btnPedido.Text = "Gerar PDF";
            btnPedido.ToolTipText = "Adicionar Pedido";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(statusStrip1);
            Controls.Add(pnlRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bar da Alegria";
            Load += TelaPrincipalForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private Panel pnlRegistros;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem produtosMenuItem;
        private ToolStripMenuItem garçonsMenuItem;
        private ToolStripMenuItem contasMenuItem;
        private ToolStripMenuItem pedidosMenuItem;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private ToolStripStatusLabel statusLabelPrincipal;
        private ToolStripButton btnFiltrar;
        private ToolStripButton btnFecharConta;
        private ToolStripButton btnNovaMesa;
        private ToolStripButton btnPedido;
        private ToolStripButton btnFaturamento;
    }
}
