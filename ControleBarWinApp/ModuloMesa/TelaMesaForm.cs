using ControleBar.Dominio.ModuloMesa;

namespace ControleBar.WinApp.ModuloMesa
{
    public partial class TelaMesaForm : Form
    {
        public Mesa Mesa
        {
            get => mesa;
            set
            {
                txtId.Text = value.Id.ToString();
                txtNumero.Text = value.Numero;
                cbOcupada.Checked = value.Ocupada == true;
            }
        }

        private Mesa mesa;

        private List<Mesa> mesasCadastradas;

        public TelaMesaForm(List<Mesa> mesasCadastradas)
        {
            InitializeComponent();

            this.mesasCadastradas = mesasCadastradas;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string numero = txtNumero.Text;
            bool ocupada = false;

            if (cbOcupada.Checked)
            {
                ocupada = true;
            }

            mesa = new Mesa(numero, ocupada);

            List<string> erros = mesa.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}