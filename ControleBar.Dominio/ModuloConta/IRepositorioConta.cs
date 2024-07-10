using ControleBar.Dominio.ModuloConta;

namespace ControleBar.Dominio.ModuloConta
{
    public interface IRepositorioConta
    {
        void Cadastrar(Conta conta);
        bool Editar(int id, Conta conta);
        bool Excluir(int id);
        Conta SelecionarPorId(int id);
        List<Conta> SelecionarTodos();
    }
}
