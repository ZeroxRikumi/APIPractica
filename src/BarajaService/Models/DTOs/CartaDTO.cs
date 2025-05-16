using System;

namespace BarajaService.Models.DTOs;

public class CartaDTO
{
    public int Id { get; set; }
    
    public string Nombre { get; set; } = string.Empty;

    public string Pinta { get; set; } = string.Empty;
}
