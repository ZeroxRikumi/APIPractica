using System;

namespace CartasService.Models.DTOs;

public class CartaDto
{
    public int Id { get; set; }
    
    public string Nombre { get; set; } = string.Empty;

    public string Pinta { get; set; } = string.Empty;

    public List<PoderDto>? Habilidades { get; set; } = new List<PoderDto>();
}
