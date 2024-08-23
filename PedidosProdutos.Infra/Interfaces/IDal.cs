using System.Linq.Expressions;

namespace PedidosProdutos.Infra.Interfaces
{
    public interface IDal<T> where T : class
    {
        IEnumerable<T> Listar();
        Task<T> AdicionarAsync(T objeto);
        void Atualizar(T objeto);
        void Deletar(T objeto);
        T? BuscarPor(Func<T, bool> condicao);
        IEnumerable<T>? BuscarTodosPor(Func<T, bool> condicao);
        Task<List<TResult>> ListarComRelacionamentosAsync<TResult>(
            Expression<Func<T, TResult>> selector,
            Expression<Func<T, bool>> predicate
        ) where TResult : class;

        public IEnumerable<TTernaria> ObterObjetosRelacionados<TEntityA, TEntityB, TTernaria>()
                                                                                                where TEntityA : class
                                                                                                where TEntityB : class
                                                                                                where TTernaria : class;

    }
}
