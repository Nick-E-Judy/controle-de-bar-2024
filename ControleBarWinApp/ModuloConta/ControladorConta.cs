
using ControleBar.Dominio.ModuloConta;
using ControleBar.Dominio.ModuloGarcom;
using ControleBar.Dominio.ModuloMesa;
using ControleBar.Dominio.ModuloProduto;
using ControleBar.WinApp.Compartilhado;
using ControleBar.WinApp.ModuloConta;
using System.Drawing.Drawing2D;

namespace ControleBar.WinApp.ModuloConta
{
    public class ControladorConta : ControladorBase, IControladorConcluir
    {
        public override string TipoCadastro => "Contas";

        public override string ToolTipAdicionar => "Cadastrar uma nova conta";

        public override string ToolTipEditar => "Editar uma conta existente";

        public override string ToolTipExcluir => "Excluir uma conta existente";

        public string ToolTipConcluir => "Fechar Conta";

        TabelaContaControl tabelaConta;

        IRepositorioConta repositorioConta;
        IRepositorioGarcom repositorioGarcom;
        IRepositorioMesa repositorioMesa;
        IRepositorioProduto repositorioProduto;

        public ControladorConta(IRepositorioConta repositorioConta, IRepositorioGarcom repositorioGarcom, IRepositorioMesa repositorioMesa, IRepositorioProduto repositorioProduto)
        {
            this.repositorioConta = repositorioConta;
            this.repositorioGarcom = repositorioGarcom;
            this.repositorioMesa = repositorioMesa;
            this.repositorioProduto = repositorioProduto;
        }

        public override void Adicionar()
        {
            List<Conta> contasCadastradas = repositorioConta.SelecionarTodos();

            TelaContaForm telaConta = new TelaContaForm(contasCadastradas);

            List<Mesa> mesasCadastradas = repositorioMesa.SelecionarTodos();
            telaConta.CarregarMesas(mesasCadastradas);

            List<Garcom> garconsCadastrados = repositorioGarcom.SelecionarTodos();
            telaConta.CarregarGarcons(garconsCadastrados);

            List<Produto> produtosCadastrados = repositorioProduto.SelecionarTodos();
            telaConta.CarregarProdutos(produtosCadastrados);

            DialogResult resultado = telaConta.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Conta novoRegistro = telaConta.Conta;

            repositorioConta.Cadastrar(novoRegistro);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoRegistro.Id}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            int idSelecionado = tabelaConta.ObterRegistroSelecionado();

            Conta contaSelecionada = repositorioConta.SelecionarPorId(idSelecionado);

            if (contaSelecionada == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            List<Conta> contasCadastradas = repositorioConta.SelecionarTodos();

            TelaContaForm telaConta = new TelaContaForm(contasCadastradas);

            telaConta.Conta = contaSelecionada;

            DialogResult resultado = telaConta.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Conta registroEditado = telaConta.Conta;

            repositorioConta.Editar(idSelecionado, registroEditado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{registroEditado.Id}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaConta.ObterRegistroSelecionado();

            Conta contaSelecionada = repositorioConta.SelecionarPorId(idSelecionado);

            if (contaSelecionada == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{contaSelecionada.Id}\" ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (resposta != DialogResult.Yes)
                return;

            repositorioConta.Excluir(idSelecionado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{contaSelecionada.Id}\" foi exluído com sucesso!");
        }

        public void Concluir()
        {
            int idSelecionado = tabelaConta.ObterRegistroSelecionado();

            Conta contaSelecionada = repositorioConta.SelecionarPorId(idSelecionado);

            if (contaSelecionada == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!contaSelecionada.Aberta)
            {
                MessageBox.Show(
                    "Você não pode fechar uma conta já fechada!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            TelaVisualizarContaForm telaFechamento = new TelaVisualizarContaForm();

            telaFechamento.Conta = contaSelecionada;

            contaSelecionada.Mesa.Ocupada = false;

            DialogResult resultado = telaFechamento.ShowDialog();

            if (resultado != DialogResult.OK)
                return;


            Conta registroEditado = telaFechamento.Conta;

            repositorioConta.Editar(idSelecionado, registroEditado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"A Conta de Id \"{registroEditado.Id}\" foi fechada com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaConta == null)
                tabelaConta = new TabelaContaControl();

            CarregarRegistros();

            return tabelaConta;
        }

        public override void CarregarRegistros()
        {
            List<Conta> contas = repositorioConta.SelecionarTodos();

            tabelaConta.AtualizarRegistros(contas);
        }
    }
}
