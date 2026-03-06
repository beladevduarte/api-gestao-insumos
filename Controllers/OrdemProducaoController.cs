using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZCK.OrdensProducao.Api.Data;
using ZCK.OrdensProducao.Api.Models;

namespace ZCK.OrdensProducao.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdemProducaoController : ControllerBase
    {
        private readonly AppDbContext _context;
        public OrdemProducaoController(AppDbContext context)
        {
            _context = context;
        }



        [HttpGet]
        public async Task<IActionResult> ListarOrdens()
        {
            var ordens = await _context.Ordens.ToListAsync();
            foreach (var ordem in ordens)
            {
                ordem.Itens = await _context.ItensReceita
                                            .Where(i => i.OrdemProducaoId == ordem.Id)
                                            .ToListAsync();
            }
            return Ok(ordens);
        }

        [HttpPost]
        public async Task<IActionResult> CriarOrdem([FromBody] OrdemProducao novaOrdem)
        {
            _context.Ordens.Add(novaOrdem);
            _context.SaveChangesAsync();
            return Ok(novaOrdem);
        }


        [HttpPut("{id}/cancelar")]
        public async Task<IActionResult> CancelarOrdem(int id)
        {
            var ordem = await _context.Ordens.FirstOrDefaultAsync(o => o.Id == id);
            ordem.Status = "Cancelada";
            await _context.SaveChangesAsync();
            return Ok(ordem);
        }
    }
}