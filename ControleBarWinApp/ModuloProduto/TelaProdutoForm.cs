using ControleBar.Dominio.ModuloProduto;

namespace ControleBar.WinApp.ModuloProduto
{
    public partial class TelaProdutoForm : Form
    {
        public Produto Produto
        {
            get => produto;
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                numPreco.Value = value.Preco;
            }
        }

        private Produto produto;

        private List<Produto> produtosCadastrados;

        public TelaProdutoForm(List<Produto> produtosCadastrados)
        {
            InitializeComponent();

            this.produtosCadastrados = produtosCadastrados;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            produto = new Produto(txtNome.Text, numPreco.Value);

            List<string> erros = produto.Validar();

            if (ProdutoTemNomeDuplicado())
                erros.Add("Já existe uma produto com este nome cadastrado, tente utilizar outro!");

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private bool ProdutoTemNomeDuplicado()
        {
            return produtosCadastrados.Any(d => d.Nome == produto.Nome);
        }
    }
}