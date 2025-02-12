using Microsoft.EntityFrameworkCore;
using Section2.Domain.Entities;

namespace Section2.Domain.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

  public  DbSet<User> Users { get; set; }
  public  DbSet<Role> Roles { get; set; }
 public  DbSet<UserRole> UserRoles { get; set; }
}
