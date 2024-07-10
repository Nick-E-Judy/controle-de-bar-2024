using ControleBar.Dominio.ModuloConta;
using ControleBar.WinApp.Compartilhado.Extensions;

namespace ControleBar.WinApp.ModuloConta
{
    public partial class TabelaContaControl : UserControl
    {
        public TabelaContaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Conta> contas)
        {
            grid.Rows.Clear();

            foreach (Conta c in contas)
                grid.Rows.Add(c.Id, c.DataAbertura, c.Aberta, c.Valor, c.Garcom, c.Mesa);
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "DataAbertura", HeaderText = "DataAbertura" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Aberta", HeaderText = "Aberta" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Garcom", HeaderText = "Garcom" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Mesa", HeaderText = "Mesa" }
            };
        }
    }
}