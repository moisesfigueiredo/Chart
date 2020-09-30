using Domain.Clientes;
using System.Collections.Generic;

namespace Service.Clientes
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteService(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public void Delete(Cliente item)
        {
            _clienteRepositorio.Excluir(item);
        }

        public List<Cliente> GetAll()
        {
            return _clienteRepositorio.ObterTodos();
        }

        public Cliente GetById(int id)
        {
            return _clienteRepositorio.ObterPorId(id);
        }

        public void Insert(Cliente item)
        {
            _clienteRepositorio.Gravar(item);
        }

        public void Update(Cliente item)
        {
            _clienteRepositorio.Atualizar(item);
        }
    }
}
