using Domain.Faturamentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorios.Faturamentos
{
    public class FaturamentoRepositorio : RepositorioBase<Faturamento>, IFaturamentoRepositorio
    {
        public FaturamentoRepositorio(ProjetoDbContext context) : base(context)
        {

        }
    }
}
