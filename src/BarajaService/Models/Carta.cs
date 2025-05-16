using System;

namespace BarajaService.Models;

public class Carta
{
    public int Id { get; set; }
    
    public string Nombre { get; set; } = string.Empty;

    public string Pinta { get; set; } = string.Empty;
}
