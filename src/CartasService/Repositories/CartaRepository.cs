using System;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CartasService.Models;
using CartasService.Data;
using CartasService.Models.DTOs;
using CartasService.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
namespace CartasService.Repositories;

public class CartaRepository : ICartaRepository
{
    private readonly CartasDBContext _context;
    private readonly IMapper _mapper;

    public CartaRepository(CartasDBContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public void AddCarta(Carta carta)
    {
        _context.Carta.Add(carta);
    }

    public async Task<Carta> GetCartaById(int id)
    {
        return await _context.Carta
                .Include(x => x.Habilidades)
                .FirstOrDefaultAsync(X => X.Id == id);
    }

    public async Task<CartaDto> GetCartaByIdAsync(int id)
    {
        return await _context.Carta
                .ProjectTo<CartaDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<CartaDto>> GetCartasAsync()
    {
        var query = _context.Carta;
        return await query.ProjectTo<CartaDto>(_mapper.ConfigurationProvider).ToListAsync();
    }

    public void RemoveCarta(Carta carta)
    {
       _context.Carta.Remove(carta);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}
