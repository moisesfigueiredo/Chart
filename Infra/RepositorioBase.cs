using Domain.Bases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infra
{
    public abstract class RepositorioBase<T> : IRepositorioBase<T> where T : EntidadeBase
    {
        private readonly ProjetoDbContext _context;

        protected RepositorioBase(ProjetoDbContext context)
        {
            _context = context;
        }

        public virtual List<T> ObterTodos()
        {
            return _context.Set<T>().ToList();
        }

        public virtual T ObterPorId(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual void Gravar(T objeto)
        {
            _context.Set<T>().Add(objeto);
            _context.SaveChanges();
        }

        public virtual void Atualizar(T objeto)
        {
            _context.Set<T>().Update(objeto);
            _context.SaveChanges();
        }

        public virtual void Excluir(T objeto)
        {
            _context.Set<T>().Remove(objeto);
            _context.SaveChanges();
        }

        public virtual List<T> Obter(Expression<Func<T, bool>> condicao)
        {
            return _context.Set<T>()
                .Where(condicao)
                .ToList();
        }

        protected IQueryable<T> ObterIncluindo(params Expression<Func<T, object>>[] propriedadesParaIncluir)
        {
            var queryable = _context.Set<T>();

            foreach (var expression in propriedadesParaIncluir)
            {
                queryable.Include(expression);
            }

            return queryable;
        }
    }
}