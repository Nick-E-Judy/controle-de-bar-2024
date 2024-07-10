using ControleBar.Dominio.ModuloConta;
using ControleBar.Dominio.ModuloGarcom;
using ControleBar.Dominio.ModuloMesa;
using ControleBar.Dominio.ModuloPedido;
using ControleBar.Dominio.ModuloProduto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Drawing.Drawing2D;
using System.Globalization;

namespace ControleBar.WinApp.ModuloConta
{
    public partial class TelaContaForm : Form
    {

        public Conta Conta
        {
            get => conta;
            set
            {
                txtId.Text = value.Id.ToString();
                cmbGarcom.SelectedItem = value.Garcom;
                cmbMesa.SelectedItem = value.Mesa;

                //foreach (Pedido p in value.Produtos)
                //{
                //    listProdutos.Items.Add(p);
                //}
            }
        }

        private Conta conta;

        private List<Conta> contasCadastradas;

        public TelaContaForm(List<Conta> contasCadastradas)
        {
            InitializeComponent();

            this.contasCadastradas = contasCadastradas;

        }

        public void CarregarMesas(List<Mesa> mesasCadastradas)
        {
            cmbMesa.Items.Clear();

            foreach (Mesa m in mesasCadastradas)
                cmbMesa.Items.Add(m);
        }
        public void CarregarGarcons(List<Garcom> garconsCadastrados)
        {
            cmbGarcom.Items.Clear();

            foreach (Garcom g in garconsCadastrados)
                cmbGarcom.Items.Add(g);
        }
        public void CarregarProdutos(List<Produto> produtosCadastrados)
        {
            cmbProduto.Items.Clear();

            foreach (Produto p in produtosCadastrados)
                cmbProduto.Items.Add(p);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = (Produto)cmbProduto.SelectedItem;
            int qtd = Convert.ToInt32(numQtd.Value);
           
            Pedido pedido = new Pedido(produto, qtd);
            listProdutos.Items.Add(pedido);
            

            AtualizarTotalConta();
        }

        private void AtualizarTotalConta()
        {
            decimal totalConta = 0;

            foreach (Pedido item in listProdutos.Items)
            {
                totalConta += item.Produto.Preco * item.Quantidade;
            }

            lblTotal.Text = totalConta.ToString("C"); 
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Garcom garcom = (Garcom)cmbGarcom.SelectedItem;
            Mesa mesa = (Mesa)cmbMesa.SelectedItem;

            string totalText = lblTotal.Text.Replace("R$", "").Trim();

            decimal valor = decimal.Parse(totalText, CultureInfo.GetCultureInfo("pt-BR"));

            List<Pedido> produtos = listProdutos.Items
            .Cast<Pedido>()
            .ToList();

            conta = new Conta(valor, produtos, garcom, mesa);

            List<string> erros = conta.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
            else
            {
                conta.Aberta = true;
            }
        }
    }
}
