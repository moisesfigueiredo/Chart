using Domain.CadastroBrutos;
using Domain.Clientes;
using Domain.Faturamentos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra
{
    public class ProjetoDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CadastroBruto> CadastroBrutos { get; set; }
        public DbSet<Faturamento> Faturamentos { get; set; }


        public ProjetoDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}