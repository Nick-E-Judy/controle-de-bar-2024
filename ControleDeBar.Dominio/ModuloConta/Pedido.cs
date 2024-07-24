﻿using ControleDeBar.Dominio.ModuloProduto;

namespace ControleDeBar.Dominio.ModuloConta
{
    public class Pedido
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int QuantidadeSolicitada { get; set; }

        public Pedido() { }

        public Pedido(Produto produto, int quantidadeEscolhida) : this()
        {
            Produto = produto;
            QuantidadeSolicitada = quantidadeEscolhida;
        }

        public decimal CalcularTotalParcial()
        {
            return Produto.Valor * QuantidadeSolicitada;
        }

        public override string ToString()
        {
            return $"{QuantidadeSolicitada}x {Produto}";
        }
    }
}