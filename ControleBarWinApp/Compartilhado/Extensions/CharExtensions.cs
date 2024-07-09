using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.WinApp.Compartilhado.Extensions
{
    public static class CharExtensions
    {
        public static char Proximo(this char caractereAtual)
        {
            int numero = caractereAtual;

            numero++;

            return (char)numero;
        }
    }
}