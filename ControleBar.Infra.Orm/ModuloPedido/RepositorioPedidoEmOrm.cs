using ControleBar.Dominio.ModuloPedido;
using ControleBar.Infra.Orm.Compartilhado;

namespace ControleBar.Infra.Orm.ModuloPedido
{
    public class RepositorioPedidoEmOrm : IRepositorioPedido
    {
        ControleBarDbContext dbContext;

        public RepositorioPedidoEmOrm(ControleBarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Cadastrar(Pedido pedido)
        {
            dbContext.Pedidos.Add(pedido);
            dbContext.SaveChanges();
        }

        public bool Editar(int id, Pedido pedidoAtualizada)
        {
            Pedido pedido = dbContext.Pedidos.Find(id)!;

            if (pedido == null)
                return false;

            pedido.AtualizarRegistro(pedidoAtualizada);

            dbContext.Pedidos.Update(pedido);
            dbContext.SaveChanges();

            return true;
        }

        public bool Excluir(int id)
        {
            Pedido pedido = dbContext.Pedidos.Find(id)!;

            if (pedido == null)
                return false;

            dbContext.Pedidos.Remove(pedido);
            dbContext.SaveChanges();

            return true;
        }

        public Pedido SelecionarPorId(int id)
        {
            return dbContext.Pedidos.Find(id)!;
        }

        public List<Pedido> SelecionarTodos()
        {
            return dbContext.Pedidos.ToList();
        }
    }
}
