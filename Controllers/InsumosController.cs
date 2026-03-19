using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZCK.OrdensProducao.Api.Data;
using ZCK.OrdensProducao.Api.Models;

namespace ZCK.OrdensProducao.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InsumosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InsumosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/insumos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Insumo>>> Get()
        {
            return await _context.Insumos.ToListAsync();
        }

        // GET: api/insumos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Insumo>> GetById(int id)
        {
            var insumo = await _context.Insumos.FindAsync(id);

            if (insumo == null)
                return NotFound();

            return insumo;
        }

        // POST: api/insumos
        [HttpPost]
        public async Task<ActionResult<Insumo>> Post(Insumo insumo)
        {
            // Validação básica
            if (string.IsNullOrWhiteSpace(insumo.Nome))
                return BadRequest("Nome é obrigatório");

            if (string.IsNullOrWhiteSpace(insumo.UnidadeMedida))
                return BadRequest("Unidade de medida é obrigatória");

            _context.Insumos.Add(insumo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = insumo.Id }, insumo);
        }

        // PUT: api/insumos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Insumo insumo)
        {
            if (id != insumo.Id)
                return BadRequest("ID da URL diferente do corpo");

            var existe = await _context.Insumos.AnyAsync(x => x.Id == id);
            if (!existe)
                return NotFound();

            _context.Entry(insumo).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/insumos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var insumo = await _context.Insumos.FindAsync(id);

            if (insumo == null)
                return NotFound();

            _context.Insumos.Remove(insumo);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}