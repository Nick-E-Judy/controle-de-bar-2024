using ControleBar.Dominio.ModuloGarcom;

namespace ControleBar.WinApp.ModuloGarcom
{
    public partial class TelaGarcomForm : Form
    {
        public Garcom Garcom
        {
            get => garcom;
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
            }
        }

        private Garcom garcom;

        private List<Garcom> garconsCadastrados;

        public TelaGarcomForm(List<Garcom> garconsCadastrados)
        {
            InitializeComponent();

            this.garconsCadastrados = garconsCadastrados;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            garcom = new Garcom(nome);

            List<string> erros = garcom.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}