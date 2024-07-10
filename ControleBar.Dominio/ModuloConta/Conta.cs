using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleBar.Dominio.Compartilhado;
using ControleBar.Dominio.ModuloGarcom;
using ControleBar.Dominio.ModuloConta;
using ControleBar.Dominio.ModuloPedido;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ControleBar.Dominio.ModuloMesa;
using ControleBar.Dominio.ModuloProduto;

namespace ControleBar.Dominio.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public decimal Valor { get; set; }
        public bool Aberta { get; set; }
        public List<Pedido> Produtos {  get; set; } 
        public DateTime DataAbertura { get; set; }
        public Garcom Garcom { get; set; }
        public Mesa Mesa { get; set; }

        public Conta()
        {

        }

        public Conta(decimal valor, List<Pedido> produtos, Garcom garcom, Mesa mesa)
        {
            Valor = valor;
            Aberta = false;
            Produtos = produtos;
            DataAbertura = DateTime.Now;
            Garcom = garcom;
            Mesa = mesa;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Conta novoConta = (Conta)novoRegistro;

            Valor = novoConta.Valor;
            Garcom = novoConta.Garcom;
            Mesa = novoConta.Mesa;
            Produtos = novoConta.Produtos;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            //if (string.IsNullOrEmpty(Numero.Trim()))
            //    erros.Add("O número deve ser preenchido!");

            return erros;
        }
    }
}