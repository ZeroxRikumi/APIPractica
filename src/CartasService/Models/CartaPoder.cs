using System;


namespace CartasService.Models;

public class CartaPoder
{
    public int CartaId { get; set; }
    public Carta Carta { get; set; } = new Carta();

    public int PoderId { get; set; }
    public Poder Poder { get; set; } = new Poder();
}
