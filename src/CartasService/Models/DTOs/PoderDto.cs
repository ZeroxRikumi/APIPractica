using System;

namespace CartasService.Models.DTOs;

public class PoderDto
{
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
