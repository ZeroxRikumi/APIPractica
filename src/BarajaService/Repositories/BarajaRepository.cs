using System;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BarajaService.Data;
using BarajaService.Models;
using BarajaService.Models.DTOs;
using BarajaService.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;


namespace BarajaService.Repositories;

public class BarajaRepository : IBarajaRepository
{
    private readonly BarajaDBContext _context;
    private readonly IMapper _mapper;

    public BarajaRepository(IMapper mapper, BarajaDBContext context)
    {
        _context = context;
        _mapper = mapper;
    }
    public void AddBaraja(Baraja baraja)
    {
        _context.Barajas.Add(baraja);
    }

    public async Task<BarajaDTO> GetBarajaAsync(int id)
    {
        return await _context.Barajas
            .ProjectTo<BarajaDTO>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Baraja> GetBarajaById(int id)
    {
        return await _context.Barajas
            .Include(x => x.Cartas)
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<List<BarajaDTO>> GetBarajasAsync()
    {
        var query = _context.Barajas;
        return await query.ProjectTo<BarajaDTO>(_mapper.ConfigurationProvider).ToListAsync();
    }

    public void RemoveBaraja(Baraja baraja)
    {
        _context.Barajas.Remove(baraja);
    }

    public async Task<bool> SaveChangesAsync()
    {
         return await _context.SaveChangesAsync() > 0;
    }
}
