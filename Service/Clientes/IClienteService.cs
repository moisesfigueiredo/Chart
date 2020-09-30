using Domain.Clientes;
using Service.Bases;
using System.Collections.Generic;

namespace Service.Clientes
{
    public interface IClienteService : IService
    {
        void Update(Cliente item);
        void Insert(Cliente item);
        void Delete(Cliente item);
        Cliente GetById(int id);
        List<Cliente> GetAll();
    }
}