using ControleBar.Dominio.ModuloGarcom;
using ControleBar.Dominio.ModuloMesa;
using ControleBar.Infra.Orm.Compartilhado;

namespace ControleBar.Infra.Orm.ModuloGarcom
{
    public class RepositorioGarcomEmOrm : IRepositorioGarcom
    {
        ControleBarDbContext dbContext;

        public RepositorioGarcomEmOrm(ControleBarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Cadastrar(Garcom garcom)
        {
            dbContext.Garcons.Add(garcom);
            dbContext.SaveChanges();
        }

        public bool Editar(int id, Garcom garcomAtualizada)
        {
            Garcom garcom = dbContext.Garcons.Find(id)!;

            if (garcom == null)
                return false;

            garcom.AtualizarRegistro(garcomAtualizada);

            dbContext.Garcons.Update(garcom);
            dbContext.SaveChanges();

            return true;
        }

        public bool Excluir(int id)
        {
            Garcom garcom = dbContext.Garcons.Find(id)!;

            if (garcom == null)
                return false;

            dbContext.Garcons.Remove(garcom);
            dbContext.SaveChanges();

            return true;
        }

        public Garcom SelecionarPorId(int id)
        {
            return dbContext.Garcons.Find(id)!;
        }

        public List<Garcom> SelecionarTodos()
        {
            return dbContext.Garcons.ToList();
        }
    }
}
