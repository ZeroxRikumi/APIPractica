using System;

namespace CartasService.Models;

public class Poder
{
    public int Id { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public EFuerza Fuerza {get; set;}

    public enum EFuerza
    {
        Debil,
        Medio,
        Fuerte,
        MuyFuerte,
        Overpower
    }
}
