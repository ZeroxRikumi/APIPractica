using System;
using CartasService.Models;
using Microsoft.EntityFrameworkCore;

namespace CartasService.Data;

public class CartasDBContext : DbContext
{
    public CartasDBContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Carta> Carta { get; set; }

    
}
