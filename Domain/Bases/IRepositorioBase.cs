using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Domain.Bases
{
    public interface IRepositorioBase<T> : IRepositorio where T : EntidadeBase
    {
        void Atualizar(T objeto);
        void Gravar(T objeto);
        void Excluir(T objeto);
        List<T> Obter(Expression<Func<T, bool>> condicao);
        T ObterPorId(int id);
        List<T> ObterTodos();
    }
}