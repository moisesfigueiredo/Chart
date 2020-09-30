using Domain.CadastroBrutos;
using Domain.Clientes;
using Domain.Faturamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Seeds
{
    public static class DataSeeder
    {
        public static void Seed(this ProjetoDbContext context)
        {
            if (!context.Clientes.Any())
            {
                List<Cliente> clientes = new List<Cliente>();

                for (int i = 1; i < 11; i++)
                {
                    clientes.Add(new Cliente { Nome = "Cliente " + i, Email = "email" + i + "@teste.com" });
                }

                context.Clientes.AddRange(clientes);

                context.SaveChanges();
            }

            if (!context.CadastroBrutos.Any())
            {
                List<CadastroBruto> cadastroBruto = new List<CadastroBruto>();
                Random random = new Random();
                List<string> classConsumo = new List<string> { "Residencial", "Comercial" };
                List<string> bairro = new List<string> { "A1", "A2", "A3", "A4", "A5"};
                List<char> municipio = new List<char> { 'A', 'B' };

                foreach (var cliente in context.Clientes)
                {
                    cadastroBruto.Add(new CadastroBruto { 
                        Id = cliente.Id, 
                        ClasseConsumo = classConsumo[random.Next(classConsumo.Count)], 
                        Municipio = municipio[random.Next(municipio.Count)], 
                        Bairro = bairro[random.Next(bairro.Count)], 
                        CoordMtMx = random.NextDouble(), 
                        Excluir = '0' 
                        });
                }

                context.CadastroBrutos.AddRange(cadastroBruto);

                context.SaveChanges();
            }

            if (!context.Faturamentos.Any())
            {
                List<Faturamento> faturamento = new List<Faturamento>();
                Random random = new Random();

                DateTime start = new DateTime(2015, 1, 1);
                int range = (DateTime.Today - start).Days;
                start.AddDays(random.Next(range));

                foreach (var cliente in context.Clientes)
                {
                    faturamento.Add(new Faturamento
                    {
                        Id = cliente.Id,
                        DataRerencia = start.AddDays(random.Next(range)),
                        ConsumoM3 = random.NextDouble(),
                        DataArquivo = start.AddDays(random.Next(range))
                    });
                }

                context.Faturamentos.AddRange(faturamento);

                context.SaveChanges();
            }
        }
    }
}
