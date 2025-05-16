using System;

namespace BarajaService.Models.DTOs;

public class CrearBarajaDTO
{
    public int Id { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public int cantidad { get; set; }

}
