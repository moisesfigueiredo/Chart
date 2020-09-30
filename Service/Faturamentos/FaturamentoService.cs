using Domain.Faturamentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Faturamentos
{
    public class FaturamentoService : IFaturamentoService
    {
        private readonly IFaturamentoRepositorio _faturamentoRepositorio;

        public FaturamentoService(IFaturamentoRepositorio faturamentoRepositorio)
        {
            _faturamentoRepositorio = faturamentoRepositorio;
        }

        public void Delete(Faturamento item)
        {
            _faturamentoRepositorio.Excluir(item);
        }

        public List<Faturamento> GetAll()
        {
            return _faturamentoRepositorio.ObterTodos();
        }

        public Faturamento GetById(int id)
        {
            return _faturamentoRepositorio.ObterPorId(id);
        }

        public void Insert(Faturamento item)
        {
            _faturamentoRepositorio.Gravar(item);
        }

        public void Update(Faturamento item)
        {
            _faturamentoRepositorio.Atualizar(item);
        }
    }
}