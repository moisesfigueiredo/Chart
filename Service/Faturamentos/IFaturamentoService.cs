using Domain.Faturamentos;
using Service.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Faturamentos
{
    public interface IFaturamentoService : IService
    {
        void Update(Faturamento item);
        void Insert(Faturamento item);
        void Delete(Faturamento item);
        Faturamento GetById(int id);
        List<Faturamento> GetAll();
    }
}