using Domain.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Faturamentos
{
    public class Faturamento : Domain.Bases.EntidadeBase
    {
        public DateTime DataRerencia { get; set; }
        public double ConsumoM3 { get; set; }
        public DateTime DataArquivo { get; set; }
        public Cliente Cliente { get; set; }
    }
}
