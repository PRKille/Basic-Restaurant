using Microsoft.EntityFrameworkCore;

namespace BasicRestaurant.Models
{
  public class BasicRestaurantContext : DbContext
  {
    public DbSet<Business> Businesses { get; set; }
    public DbSet<BoardMember> BoardMembers { get; set; }

    public BasicRestaurantContext(DbContextOptions options) : base(options) { }
  }
}