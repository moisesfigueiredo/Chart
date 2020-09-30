using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using Service.CadastroBrutos;
using Service.Faturamentos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    [Route("api/chart")]
    public class ChartRestController : Controller
    {
        private readonly ICadastroService _cadastroService;
        private readonly IFaturamentoService _faturamentoService;

        public ChartRestController(ICadastroService cadastroService, IFaturamentoService faturamentoService)
        {
            _cadastroService = cadastroService;
            _faturamentoService = faturamentoService;
        }

        [HttpGet("ChartCadastroByBairro")]
        [Produces("application/json")]
        public async Task<IActionResult> ChartByBairro()
        {
            try
            {
                var todosCadastros = _cadastroService.GetAll();
                var dadosChart = new List<CadastroChartViewModel>();

                foreach (var bairro in todosCadastros.GroupBy(car => car.Bairro).Select(g => g.First()).ToList())
                {
                    dadosChart.Add(new CadastroChartViewModel { Id = bairro.Bairro, Valor = todosCadastros.Where(c => c.Bairro == bairro.Bairro).Count() });
                }

                return Ok(dadosChart.OrderBy(d => d.Id));
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("ChartFaturamentoByDataReferencia")]
        [Produces("application/json")]
        public async Task<IActionResult> ChartFaturamentoByDataReferencia()
        {
            try
            {
                var faturamentos = _faturamentoService.GetAll();
                var dadosChart = new List<FaturamentoChartViewModel>();

                foreach (var faturamento in faturamentos)
                {
                    dadosChart.Add(new FaturamentoChartViewModel { Id = faturamento.DataRerencia.ToString("dd/mm/yyyy"), Valor = faturamento.ConsumoM3 });
                }

                return Ok(dadosChart.OrderBy(d => d.Id));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}