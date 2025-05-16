using System;
using CartasService.Models;
using CartasService.Models.DTOs;

namespace CartasService.Repositories.IRepositories;

public interface ICartaRepository
{
    Task<List<CartaDto>> GetCartasAsync();
    Task<CartaDto> GetCartaByIdAsync(int id);
    Task<Carta> GetCartaById(int id);
    void AddCarta(Carta carta);
    void RemoveCarta(Carta carta);
    Task<bool> SaveChangesAsync();
}
