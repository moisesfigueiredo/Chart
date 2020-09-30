using Domain.CadastroBrutos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorios.CadastroBrutos
{
    public class CadastroBrutoRepositorio : RepositorioBase<CadastroBruto>, ICadastroRepositorio
    {
        public CadastroBrutoRepositorio(ProjetoDbContext context) : base(context)
        {

        }
    }
}
