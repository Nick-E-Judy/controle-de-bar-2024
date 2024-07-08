using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleBar.Dominio.ModuloGarcom;
using ControleBar.Dominio.ModuloPedido;

namespace ControleBar.Dominio.ModuloConta
{
    public class Conta
    {

        public int Valor { get; set; }

        public bool Aberta
        {
            get => default;
            set
            {
            }
        }

        public List<Pedido> Pedidos
        {
            get => default;
            set
            {
            }
        }

        public DateTime DataAbertura
        {
            get => default;
            set
            {
            }
        }

        public Garcom Garcom
        {
            get => default;
            set
            {
            }
        }

        public Mesa Mesa
        {
            get => default;
            set
            {
            }
        }
    }
}