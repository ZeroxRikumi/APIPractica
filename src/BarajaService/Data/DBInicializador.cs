using System;
using Microsoft.EntityFrameworkCore;
using BarajaService.Models;

namespace BarajaService.Data;

public class DBInicializador
{
    public static void InitDB(WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        SeedData(scope.ServiceProvider.GetService<BarajaDBContext>());

    }

    private static void SeedData(BarajaDBContext context)
    {
        context.Database.Migrate();

        if (context.Barajas.Any())
        {
            return;
        }

        var barajas = new List<Baraja>()
        {
            new Baraja
            {
                Id = 1,
                Nombre = "Baraja Explosiva",
                cantidad = 5,
                Cartas = new List<Carta>
                {
                    new Carta
                    {
                        Id = 1,
                        Nombre = "K de Corazones",
                        Pinta = "corazones",
                        BarajaId = 1
                    },
                    new Carta
                    {
                        Id = 2,
                        Nombre = "Q de Corazones",
                        Pinta = "corazones",
                        BarajaId = 1
                    },
                    new Carta
                    {
                        Id = 3,
                        Nombre = "J de Corazones",
                        Pinta = "corazones",
                        BarajaId = 1
                    },
                    new Carta
                    {
                        Id = 4,
                        Nombre = "4 de Corazones",
                        Pinta = "corazones",
                        BarajaId = 1
                    },
                    new Carta
                    {
                        Id = 5,
                        Nombre = "3 de Corazones",
                        Pinta = "corazones",
                        BarajaId = 1
                    }
                }
            },
            new Baraja
            {
                Id = 2,
                Nombre = "Baraja Real",
                cantidad = 5,
                Cartas = new List<Carta>
                {
                    new Carta
                    {
                        Id = 6,
                        Nombre = "K de Espadas",
                        Pinta = "espadas",
                        BarajaId = 2
                    },
                    new Carta
                    {
                        Id = 7,
                        Nombre = "Q de Espadas",
                        Pinta = "espadas",
                        BarajaId = 2
                    },
                    new Carta
                    {
                        Id = 8,
                        Nombre = "J de Espadas",
                        Pinta = "espadas",
                        BarajaId = 2
                    },
                    new Carta
                    {
                        Id = 9,
                        Nombre = "10 de Espadas",
                        Pinta = "espadas",
                        BarajaId = 2
                    },
                    new Carta
                    {
                        Id = 10,
                        Nombre = "A de Espadas",
                        Pinta = "espadas",
                        BarajaId = 2
                    }
                }
            }
        };

        context.AddRange(barajas);
        context.SaveChanges();
    }
}
