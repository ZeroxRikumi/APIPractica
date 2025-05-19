using System;
using CartasService.Data;
using CartasService.Models;
using Microsoft.EntityFrameworkCore;

namespace CartasService.Data;

public class DbIniciador
{
    public static void InitDB(WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        SeedData(scope.ServiceProvider.GetService<CartasDBContext>());

    }

    private static void SeedData(CartasDBContext context)
    {
        context.Database.Migrate();

        if (context.Carta.Any())
        {
            return;
        }

        var cartas = new List<Carta>()
        {
            new Carta
            {
                Id = 1,
                Nombre = "K de Trebol",
                Pinta = "trebol",
                Habilidades = new List<Poder>
                {
                    new Poder
                    {
                        Id = 1,
                        Nombre = "Cambio de Treboles",
                        Fuerza  = 0,
                        CartaId = 1
                    },
                    new Poder
                    {
                        Id = 2,
                        Nombre = "Descarte Agresivo",
                        Fuerza  = 0,
                        CartaId = 1
                    }

                }
            },
            new Carta
            {
                Id = 2,
                Nombre = "J de Diamantes",
                Pinta = "diamantes",
                Habilidades = new List<Poder>
                {
                    new Poder
                    {
                        Id = 1,
                        Nombre = "Bloqueo de Diamante",
                        Fuerza  = 0,
                        CartaId = 2
                    }

                }
            },
            new Carta
            {
                Id = 3,
                Nombre = "4 de Espadas",
                Pinta = "Espadas",
                Habilidades = new List<Poder>
                {}
            }
        };
    }
}
