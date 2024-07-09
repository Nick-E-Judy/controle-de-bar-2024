using ControleBar.Dominio.Compartilhado;
using ControleBar.Dominio.ModuloConta;

namespace ControleBar.Dominio.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public int Numero {  get; set; }
        public bool Ocupada { get; set; }
        //public Conta Conta { get; set; }

        public Mesa(int numero, bool ocupada)
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

            if (Numero <= 0)
                erros.Add("O número da mesa deve ser maior que 0");

            return erros;
        }

    }
}