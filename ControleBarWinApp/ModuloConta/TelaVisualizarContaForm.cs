using ControleBar.Dominio.ModuloConta;
using ControleBar.Dominio.ModuloPedido;
using ControleBar.WinApp.Compartilhado.Extensions;

namespace ControleBar.WinApp.ModuloConta
{
    public partial class TelaVisualizarContaForm : Form
    {
        private Conta conta;
        public Conta Conta
        {
            get { return conta; }
            set
            {
                conta = value;
                lblNumMesa.Text = "" + value.Mesa;
                lblNomeGarcom.Text = "" + value.Garcom;
                foreach (Pedido p in value.Produtos)
                {
                    listPedidos.Items.Add(p);
                }
                lblTotalConta.Text = "" + value.Valor;
            }
        }

        public TelaVisualizarContaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        private void btnFecharConta_Click(object sender, EventArgs e)
        {
            conta.Mesa.Ocupada = false;
            conta.Aberta = false;
        }
    }
}
