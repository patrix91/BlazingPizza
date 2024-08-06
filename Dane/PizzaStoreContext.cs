using BlazingPizza.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlazingPizza.Dane;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<PizzaSpecial> Specials { get; set; }
}