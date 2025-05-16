using System;
using BarajaService.Models;
using BarajaService.Models.DTOs;

namespace BarajaService.Repositories.IRepositories;

public interface IBarajaRepository
{
    Task<List<BarajaDTO>> GetBarajasAsync();
    Task<BarajaDTO> GetBarajaAsync(int id);
    Task<Baraja> GetBarajaById(int id);
    void AddBaraja(Baraja baraja);
    void RemoveBaraja(Baraja baraja);
    Task<bool> SaveChangesAsync();
}
