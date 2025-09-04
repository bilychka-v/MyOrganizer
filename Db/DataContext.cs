using Domain;
using Microsoft.EntityFrameworkCore;

namespace Db;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
   public DbSet<Users> Users { get; set; }
   public DbSet<Tasks> Tasks {get;set;}
   public DbSet<Categories> Categories {get;set;}
}