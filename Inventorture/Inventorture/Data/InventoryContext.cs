using Inventorture.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventorture.Data;

public class InventoryContext : DbContext
{
    public InventoryContext(DbContextOptions<InventoryContext> options)
        : base(options)
    {
    }

    public DbSet<Item> Items => Set<Item>();
}