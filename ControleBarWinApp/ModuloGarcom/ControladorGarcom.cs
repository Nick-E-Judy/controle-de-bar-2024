using ControleBar.Dominio.ModuloGarcom;
using ControleBar.WinApp.Compartilhado;
using ControleBar.WinApp.ModuloMesa;

namespace ControleBar.WinApp.ModuloGarcom
{
    public class ControladorGarcom : ControladorBase
    {
        public override string TipoCadastro => "Garçons";

        public override string ToolTipAdicionar => "Cadastrar um novo garcom";

        public override string ToolTipEditar => "Editar um garçom existente";

        public override string ToolTipExcluir => "Excluir um garçom existente";

        TabelaGarcomControl tabelaGarcom;

        IRepositorioGarcom repositorioGarcom;

        public ControladorGarcom(IRepositorioGarcom repositorioGarcom)
        {
            this.repositorioGarcom = repositorioGarcom;
        }

        public override void Adicionar()
        {
            List<Garcom> garcomsCadastradas = repositorioGarcom.SelecionarTodos();

            TelaGarcomForm telaGarcom = new TelaGarcomForm(garcomsCadastradas);

            DialogResult resultado = telaGarcom.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Garcom novoRegistro = telaGarcom.Garcom;

            repositorioGarcom.Cadastrar(novoRegistro);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoRegistro.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            int idSelecionado = tabelaGarcom.ObterRegistroSelecionado();

            Garcom garcomSelecionada = repositorioGarcom.SelecionarPorId(idSelecionado);

            if (garcomSelecionada == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            List<Garcom> garcomsCadastradas = repositorioGarcom.SelecionarTodos();

            TelaGarcomForm telaGarcom = new TelaGarcomForm(garcomsCadastradas);

            telaGarcom.Garcom = garcomSelecionada;

            DialogResult resultado = telaGarcom.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Garcom registroEditado = telaGarcom.Garcom;

            repositorioGarcom.Editar(idSelecionado, registroEditado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{registroEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaGarcom.ObterRegistroSelecionado();

            Garcom garcomSelecionada = repositorioGarcom.SelecionarPorId(idSelecionado);

            if (garcomSelecionada == null)
            {
                MessageBox.Show(
                    "Você precisa selecionar um registro para executar esta ação!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{garcomSelecionada.Nome}\" ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (resposta != DialogResult.Yes)
                return;

            repositorioGarcom.Excluir(idSelecionado);

            CarregarRegistros();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{garcomSelecionada.Nome}\" foi exluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaGarcom == null)
                tabelaGarcom = new TabelaGarcomControl();

            CarregarRegistros();

            return tabelaGarcom;
        }

        public override void CarregarRegistros()
        {
            List<Garcom> garcoms = repositorioGarcom.SelecionarTodos();

            tabelaGarcom.AtualizarRegistros(garcoms);
        }
    }
}