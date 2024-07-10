using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.WinApp.Compartilhado
{
    public interface IControladorConcluir
    {
        string ToolTipConcluir { get; }
        void Concluir();
    }
}
