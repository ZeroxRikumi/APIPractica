using System;

namespace BarajaService.Models;

public class Baraja
{
    public int Id { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public int cantidad { get; set; }

    public List<Carta> Cartas { get; set; } = new List<Carta>();
}
