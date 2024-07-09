using ControleBar.Dominio.ModuloMesa;
using ControleBar.WinApp.Compartilhado.Extensions;


namespace ControleBar.WinApp.ModuloMesa
{
    public partial class TabelaMesaControl : UserControl
    {
        public TabelaMesaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Mesa> mesas)
        {
            grid.Rows.Clear();

            foreach (Mesa m in mesas)
                grid.Rows.Add(m.Id, m.Numero, m.Ocupada);
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Numero", HeaderText = "Numero" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Ocupada", HeaderText = "Ocupada" }
            };
        }
    }
}
