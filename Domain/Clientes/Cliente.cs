using Domain.Bases;
using Domain.CadastroBrutos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Clientes
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Regiao { get; set; }
        public virtual CadastroBruto Cadastro { get; set; }
    }
}
