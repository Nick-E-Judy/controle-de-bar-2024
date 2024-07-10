using ControleBar.WinApp.Compartilhado;
using ControleBar.Dominio.ModuloProduto;
using ControleBar.Infra.Orm.ModuloProduto;
using ControleBar.WinApp.ModuloProduto;
using ControleBar.Infra.Orm.Compartilhado;
using ControleBar.Infra.Orm.ModuloMesa;
using ControleBar.Dominio.ModuloMesa;
using ControleBar.WinApp.ModuloMesa;
using ControleBar.Dominio.ModuloGarcom;
using ControleBar.Infra.Orm.ModuloGarcom;
using ControleBar.WinApp.ModuloGarcom;
using ControleBar.Dominio.ModuloConta;
using ControleBar.Infra.Orm.ModuloConta;
using ControleBar.WinApp.ModuloConta;

namespace ControleBar.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        public static TelaPrincipalForm Instancia { get; private set; }

        ControladorBase controlador;

        IRepositorioProduto repositorioProduto;
        IRepositorioMesa repositorioMesa;
        IRepositorioGarcom repositorioGarcom;
        IRepositorioConta repositorioConta;
        public TelaPrincipalForm()
        {
            InitializeComponent();
            Instancia = this;

            ControleBarDbContext dbContext = new ControleBarDbContext();

            repositorioProduto = new RepositorioProdutoEmOrm(dbContext);
            repositorioMesa = new RepositorioMesaEmOrm(dbContext);
            repositorioGarcom = new RepositorioGarcomEmOrm(dbContext);
            repositorioConta = new RepositorioContaEmOrm(dbContext);
        }

        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        private void produtosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorProduto(repositorioProduto);

            ConfigurarTelaPrincipal(controlador);
        }

        private void mesasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMesa(repositorioMesa);

            ConfigurarTelaPrincipal(controlador);
        }

        private void garçonsMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorGarcom(repositorioGarcom);

            ConfigurarTelaPrincipal(controlador);
        }

        private void contasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorConta(repositorioConta, repositorioGarcom, repositorioMesa, repositorioProduto);

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            btnFecharConta.Enabled = controladorSelecionado is IControladorConcluir;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;


            if (controladorSelecionado is IControladorConcluir controladorConcluir)
                btnFecharConta.ToolTipText = controladorConcluir.ToolTipConcluir;
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controladorSelecionado.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
        }

        private void btnFecharConta_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorConcluir controladorConcluir)
                controladorConcluir.Concluir();
        }
    }
}
