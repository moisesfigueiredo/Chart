using Domain.CadastroBrutos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.CadastroBrutos
{
   public class CadastroService : ICadastroService
    {
        private readonly ICadastroRepositorio _cadastroRepositorio;

        public CadastroService(ICadastroRepositorio clienteRepositorio)
        {
            _cadastroRepositorio = clienteRepositorio;
        }

        public void Delete(CadastroBruto item)
        {
            _cadastroRepositorio.Excluir(item);
        }

        public List<CadastroBruto> GetAll()
        {
            return _cadastroRepositorio.ObterTodos();
        }

        public CadastroBruto GetById(int id)
        {
            return _cadastroRepositorio.ObterPorId(id);
        }

        public void Insert(CadastroBruto item)
        {
            _cadastroRepositorio.Gravar(item);
        }

        public void Update(CadastroBruto item)
        {
            _cadastroRepositorio.Atualizar(item);
        }
    }
}
