using System;

namespace BarajaService.Models.DTOs;

public class BarajaDTO
{
    public int Id { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public int cantidad { get; set; }

    public List<CartaDTO> Cartas { get; set; } = new List<CartaDTO>();
}
