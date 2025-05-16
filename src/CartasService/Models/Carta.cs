using System;

namespace CartasService.Models;

public class Carta
{
    public int Id { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public string Pinta { get; set; } = string.Empty;

    public List<Poder>? Habilidades { get; set; } = new List<Poder>();
}
