using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace ValveShop.Storage
{
  public class StorageContext: DbContext
  {
    public StorageContext()
    {
      Database.EnsureCreated();
    }
    public DbSet<MainMenuItem> MainMenuItems { get; set; }
    public DbSet<FollowedMenuItem> FollowedMenuItems { get; set; }
    public DbSet<ProductProperty> ProductProperties { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      builder.ApplyConfiguration(new ItemConfiguration());
      builder.ApplyConfiguration(new UserItemConfiguration());
    }
  }
}