using ControleBar.Dominio.ModuloProduto;
using ControleBar.Infra.Orm.Compartilhado;

namespace ControleBar.Infra.Orm.ModuloProduto
{
    public class RepositorioProdutoEmOrm : IRepositorioProduto
    {
        ControleBarDbContext dbContext;

        public RepositorioProdutoEmOrm(ControleBarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Cadastrar(Produto produto)
        {
            dbContext.Produtos.Add(produto);
            dbContext.SaveChanges();
        }

        public bool Editar(int id, Produto produtoAtualizada)
        {
            Produto produto = dbContext.Produtos.Find(id)!;

            if (produto == null)
                return false;

            produto.AtualizarRegistro(produtoAtualizada);

            dbContext.Produtos.Update(produto);
            dbContext.SaveChanges();

            return true;
        }

        public bool Excluir(int id)
        {
            Produto produto = dbContext.Produtos.Find(id)!;

            if (produto == null)
                return false;

            dbContext.Produtos.Remove(produto);
            dbContext.SaveChanges();

            return true;
        }

        public Produto SelecionarPorId(int id)
        {
            return dbContext.Produtos.Find(id)!;
        }

        public List<Produto> SelecionarTodos()
        {
            return dbContext.Produtos.ToList();
        }
    }
}
