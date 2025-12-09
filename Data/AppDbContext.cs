using System;
using API_DatingApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_DatingApp.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    
    public DbSet<AppUser> Users { get; set; }
}


/*
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<AppUser> Users { get; set; }

}
*/