using ControleBar.Dominio.ModuloMesa;

namespace ControleBar.Dominio.ModuloGarcom
{
    public interface IRepositorioGarcom
    {
        void Cadastrar(Garcom garcom);
        bool Editar(int id, Garcom garcom);
        bool Excluir(int id);
        Garcom SelecionarPorId(int id);
        List<Garcom> SelecionarTodos();
    }
}
