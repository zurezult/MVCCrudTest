using System;
using Microsoft.EntityFrameworkCore;
using CrudMVC.Models;

namespace CrudMVC.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    public DbSet<Category> Categories {get; set;}

}