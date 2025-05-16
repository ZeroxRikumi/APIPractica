using System;
using Microsoft.EntityFrameworkCore;

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

    }
}
