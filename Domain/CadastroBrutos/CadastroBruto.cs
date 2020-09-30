using Domain.Bases;
using Domain.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.CadastroBrutos
{
    public class CadastroBruto : EntidadeBase
    {
        [ForeignKey("Cliente")]
        public override int Id { get; set; }
        public virtual Cliente Cliente { get; set; }
        public string ClasseConsumo { get; set; }
        public char Municipio { get; set; }
        public string Bairro { get; set; }
        public double CoordMtMx { get; set; }
        public double CoordMtMy { get; set; }
        public char Excluir { get; set; }
        public DateTime DataArquivo { get; set; }

    }
}
