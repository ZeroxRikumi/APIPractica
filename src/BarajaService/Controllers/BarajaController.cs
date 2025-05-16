using System.Text;
using AutoMapper;
using BarajaService.Models;
using BarajaService.Models.DTOs;
using BarajaService.Repositories.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BarajaService.Controllers
{
    [Route("api/barajas")]
    [ApiController]
    public class BarajaController : ControllerBase
    {
        private readonly IBarajaRepository _repo;
        private readonly IMapper _mapper;

        public BarajaController(IBarajaRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<BarajaDTO>>> GetAllBarajas()
        {
            return await _repo.GetBarajasAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BarajaDTO>> GetBarajaById(int id)
        {
            var baraja = await _repo.GetBarajaAsync(id);
            if (baraja == null) return NotFound();
            return baraja;
        }

        [HttpPost]
        public async Task<ActionResult<BarajaDTO>> CrearBaraja(CrearBarajaDTO barajaDTO)
        {
            var baraja = _mapper.Map<Baraja>(barajaDTO);
            _repo.AddBaraja(baraja);
            var newBaraja = _mapper.Map<BarajaDTO>(baraja);
            var result = await _repo.SaveChangesAsync();
            if (!result)
                return BadRequest("No se ha podiddo crear la baraja nueva");

            return CreatedAtAction(nameof(GetBarajaById),
                new { baraja.Id }, newBaraja);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteBaraja(int id)
        {
            var baraja = await _repo.GetBarajaById(id);
            if (baraja == null) return NotFound();
            _repo.RemoveBaraja(baraja);
            var result = await _repo.SaveChangesAsync();

            if (!result) return BadRequest("No se pudo establecer la conexión a la BD");
            return Ok(); 
        }

    }
}
