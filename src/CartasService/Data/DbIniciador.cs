using System;
using CartasService.Data;
using Microsoft.EntityFrameworkCore;

namespace CartasService.Data;

public class DbIniciador
{
    public static void InitDB(WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        SeedData(scope.ServiceProvider.GetService<AppDBContext>());

    }

    private static void SeedData(AppDBContext context)
    {
        context.Database.Migrate();

    }
}
