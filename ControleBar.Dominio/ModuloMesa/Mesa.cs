using ControleBar.Dominio.Compartilhado;
using ControleBar.Dominio.ModuloConta;

namespace ControleBar.Dominio.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public string Numero {  get; set; }
        public bool Ocupada { get; set; }
        //public Conta Conta { get; set; }

        public Mesa(string numero, bool ocupada)
        {
            Numero = numero;
            Ocupada = ocupada;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Mesa novoMesa = (Mesa)novoRegistro;

            Numero = novoMesa.Numero;
            Ocupada = novoMesa.Ocupada;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Numero.Trim()))
                erros.Add("O número deve ser preenchido!");

            return erros;
        }
    }
}