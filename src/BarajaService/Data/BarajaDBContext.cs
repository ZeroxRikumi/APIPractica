using System;
using BarajaService.Models;
using Microsoft.EntityFrameworkCore;

namespace BarajaService.Data;

public class BarajaDBContext : DbContext
{
    public BarajaDBContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Baraja> Barajas { get; set; }
}
