using ControleBar.Dominio.Compartilhado;
using ControleBar.Dominio.ModuloMesa;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControleBar.Dominio.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {
        public string Nome { get; set; }
     
        public Garcom(string nome)
        {
            Nome = nome;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Garcom novoGarcom = (Garcom)novoRegistro;

            Nome = novoGarcom.Nome;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O nome deve ser preenchido!");

            return erros;
        }

    }
}