using AutoMapper;
using CartasService.Repositories.IRepositories;
using CartasService.Models;
using CartasService.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CartasService.Controllers;


[ApiController]
[Route("api/cartas")]
public class CartaController : ControllerBase
{
    private readonly ICartaRepository _repo;
    private readonly IMapper _mapper;

    public CartaController(ICartaRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<CartaDto>>> GetAllCartas()
    {
        return await _repo.GetCartasAsync();
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<CartaDto>> GetCartaById(int id)
    {
        var carta = await _repo.GetCartaByIdAsync(id);
        if (carta == null) return NotFound();
        return carta;
    }

    [HttpPost]
    public async Task<ActionResult<CartaDto>> CrearCarta(CreateCardDto cartaDto)
    {
        var carta = _mapper.Map<Carta>(cartaDto);
        _repo.AddCarta(carta);
        var newCarta = _mapper.Map<CartaDto>(carta);
        var resultado = await _repo.SaveChangesAsync();
        if(!resultado)
            return BadRequest("No se a podido crear la nueva carta en la BD");
        
        return CreatedAtAction(nameof(GetCartaById),
            new {carta.Id}, newCarta);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteCarta(int id)
    {
        var carta = await _repo.GetCartaById(id);
        if (carta == null) return NotFound();
        _repo.RemoveCarta(carta);
        var result = await _repo.SaveChangesAsync();

        if (!result) return BadRequest("No se pudo actualizar la BD");
        return Ok();
        
    }
}

