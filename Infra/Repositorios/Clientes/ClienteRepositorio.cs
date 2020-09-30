using Domain.Clientes;

namespace Infra.Repositorios.Clientes
{
    public class ClienteRepositorio : RepositorioBase<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(ProjetoDbContext context) : base(context)
        {

        }
    }
}
