﻿namespace ControleDeBar.WinApp
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
            menu = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            mesasMenuItem = new ToolStripMenuItem();
            garconsMenuItem = new ToolStripMenuItem();
            produtosMenuItem = new ToolStripMenuItem();
            contasMenuItem = new ToolStripMenuItem();
            toolbox = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnVisualizar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            pnlRegistros = new Panel();
            menu.SuspendLayout();
            toolbox.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(5);
            menu.Size = new Size(1038, 34);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mesasMenuItem, garconsMenuItem, produtosMenuItem, contasMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(86, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // mesasMenuItem
            // 
            mesasMenuItem.Name = "mesasMenuItem";
            mesasMenuItem.ShortcutKeys = Keys.F1;
            mesasMenuItem.Size = new Size(161, 24);
            mesasMenuItem.Text = "Mesas";
            mesasMenuItem.Click += mesasMenuItem_Click;
            // 
            // garconsMenuItem
            // 
            garconsMenuItem.Name = "garconsMenuItem";
            garconsMenuItem.ShortcutKeys = Keys.F2;
            garconsMenuItem.Size = new Size(161, 24);
            garconsMenuItem.Text = "Garçons";
            garconsMenuItem.Click += garconsMenuItem_Click;
            // 
            // produtosMenuItem
            // 
            produtosMenuItem.Name = "produtosMenuItem";
            produtosMenuItem.ShortcutKeys = Keys.F3;
            produtosMenuItem.Size = new Size(161, 24);
            produtosMenuItem.Text = "Produtos";
            produtosMenuItem.Click += produtosMenuItem_Click;
            // 
            // contasMenuItem
            // 
            contasMenuItem.Name = "contasMenuItem";
            contasMenuItem.ShortcutKeys = Keys.F4;
            contasMenuItem.Size = new Size(161, 24);
            contasMenuItem.Text = "Contas";
            contasMenuItem.Click += contasMenuItem_Click;
            // 
            // toolbox
            // 
            toolbox.GripStyle = ToolStripGripStyle.Hidden;
            toolbox.ImageScalingSize = new Size(20, 20);
            toolbox.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator2, btnFiltrar, toolStripSeparator4, btnVisualizar, toolStripSeparator3, lblTipoCadastro });
            toolbox.Location = new Point(0, 34);
            toolbox.Name = "toolbox";
            toolbox.Padding = new Padding(10, 5, 10, 5);
            toolbox.Size = new Size(1038, 51);
            toolbox.TabIndex = 1;
            toolbox.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Enabled = false;
            btnAdicionar.Font = new Font("Segoe UI", 11.25F);
            btnAdicionar.Image = Properties.Resources.btnAdicionar;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(5);
            btnAdicionar.Size = new Size(111, 38);
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 11.25F);
            btnEditar.Image = Properties.Resources.btnEditar;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(86, 38);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Segoe UI", 11.25F);
            btnExcluir.Image = Properties.Resources.btnExcluir;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(90, 38);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 41);
            // 
            // btnFiltrar
            // 
            btnFiltrar.Enabled = false;
            btnFiltrar.Font = new Font("Segoe UI", 11.25F);
            btnFiltrar.Image = Properties.Resources.btnFiltrar;
            btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(5);
            btnFiltrar.Size = new Size(85, 38);
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 41);
            // 
            // btnVisualizar
            // 
            btnVisualizar.Enabled = false;
            btnVisualizar.Font = new Font("Segoe UI", 11.25F);
            btnVisualizar.Image = Properties.Resources.btnVisualizarFaturamento;
            btnVisualizar.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizar.ImageTransparentColor = Color.Magenta;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Padding = new Padding(5);
            btnVisualizar.Size = new Size(197, 38);
            btnVisualizar.Text = "Visualizar Faturamento";
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 41);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Padding = new Padding(5);
            lblTipoCadastro.Size = new Size(158, 38);
            lblTipoCadastro.Text = "Seja Bem-Vindo(a)!";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 592);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1038, 29);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Padding = new Padding(2);
            statusLabelPrincipal.Size = new Size(71, 24);
            statusLabelPrincipal.Text = "[rodapé]";
            // 
            // pnlRegistros
            // 
            pnlRegistros.Dock = DockStyle.Fill;
            pnlRegistros.Location = new Point(0, 85);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(1038, 507);
            pnlRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 621);
            Controls.Add(pnlRegistros);
            Controls.Add(statusStrip1);
            Controls.Add(toolbox);
            Controls.Add(menu);
            MainMenuStrip = menu;
            MinimumSize = new Size(702, 458);
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Bar";
            WindowState = FormWindowState.Maximized;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            toolbox.ResumeLayout(false);
            toolbox.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosMenuItem;
        private System.Windows.Forms.ToolStrip toolbox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlRegistros;
        private System.Windows.Forms.ToolStripButton btnAdicionar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelPrincipal;
        private System.Windows.Forms.ToolStripButton btnFiltrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblTipoCadastro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem garconsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasMenuItem;
        private System.Windows.Forms.ToolStripButton btnVisualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}
