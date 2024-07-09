using ControleBar.Dominio.ModuloProduto;
using ControleBar.WinApp.Compartilhado;

namespace ControleBar.WinApp.ModuloProduto
{
    public class ControladorProduto : ControladorBase
    {
        public override string TipoCadastro => "Produtos";

        public override string ToolTipAdicionar => "Cadastrar um novo produto";

        public override string ToolTipEditar => "Editar um produto existente";

        public override string ToolTipExcluir => "Excluir um produto existente";

        TabelaProdutoControl tabelaProduto;

        IRepositorioProduto repositorioProduto;

        public ControladorProduto(IRepositorioProduto repositorioProduto)
        {
            this.repositorioProduto = repositorioProduto;
        }

        public override void Adicionar()
        {
            List<Produto> produtosCadastradas = repositorioProduto.SelecionarTodos();

            TelaProdutoForm telaProduto = new TelaProdutoForm(produtosCadastradas);

            DialogResult resultado = telaProduto.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Produto novoRegistro = telaProduto.Produto;

            repositorioProduto.Cadastrar(novoRegistro);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoRegistro.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            int idSelecionado = tabelaProduto.ObterRegistroSelecionado();

            Produto produtoSelecionado = repositorioProduto.SelecionarPorId(idSelecionado);

            if (produtoSelecionado == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            List<Produto> produtosCadastradas = repositorioProduto.SelecionarTodos();

            TelaProdutoForm telaProduto = new TelaProdutoForm(produtosCadastradas);

            telaProduto.Produto = produtoSelecionado;

            DialogResult resultado = telaProduto.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Produto registroEditado = telaProduto.Produto;

            repositorioProduto.Editar(idSelecionado, registroEditado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{registroEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaProduto.ObterRegistroSelecionado();

            Produto produtoSelecionado = repositorioProduto.SelecionarPorId(idSelecionado);

            if (produtoSelecionado == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{produtoSelecionado.Nome}\" ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (resposta != DialogResult.Yes)
                return;

            repositorioProduto.Excluir(idSelecionado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{produtoSelecionado.Nome}\" foi exluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaProduto == null)
                tabelaProduto = new TabelaProdutoControl();

            CarregarRegistros();

            return tabelaProduto;
        }

        public override void CarregarRegistros()
        {
            List<Produto> produtos = repositorioProduto.SelecionarTodos();

            tabelaProduto.AtualizarRegistros(produtos);
        }
    }
}
