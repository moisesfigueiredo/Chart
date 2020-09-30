using Domain.CadastroBrutos;
using Domain.Clientes;
using Service.Bases;
using System.Collections.Generic;


namespace Service.CadastroBrutos
{
    public interface ICadastroService : IService
    {
        void Update(CadastroBruto item);
        void Insert(CadastroBruto item);
        void Delete(CadastroBruto item);
        CadastroBruto GetById(int id);
        List<CadastroBruto> GetAll();
    }
}