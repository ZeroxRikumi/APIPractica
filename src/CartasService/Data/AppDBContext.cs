using System;
using CartasService.Models;
using Microsoft.EntityFrameworkCore;

namespace CartasService.Data;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Carta> Carta { get; set; }

    
}
