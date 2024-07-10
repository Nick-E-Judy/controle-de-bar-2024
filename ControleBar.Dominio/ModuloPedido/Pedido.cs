using ControleBar.Dominio.Compartilhado;
using ControleBar.Dominio.ModuloProduto;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControleBar.Dominio.ModuloPedido
{
    public class Pedido : EntidadeBase
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public Pedido() 
        {
            
        }

        public Pedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            Valor = quantidade * produto.Preco;
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"x{Quantidade} {Produto} R${Valor}";
        }
    }
}