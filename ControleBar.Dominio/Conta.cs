using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleBar.Dominio
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