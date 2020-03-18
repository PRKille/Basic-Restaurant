using Microsoft.EntityFrameworkCore;

namespace BasicRestaurant.Models
{
  public class BasicRestaurantContext : DbContext
  {
    public DbSet<Business> Businesses { get; set; }
    public DbSet<BoardMember> Board_Members { get; set; }

    public BasicRestaurantContext(DbContextOptions options) : base(options) { } 
    //established connection and meaning of option in startup line startup line 28-29
  }
}