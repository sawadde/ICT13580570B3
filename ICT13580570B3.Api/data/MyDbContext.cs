using System;
using ICT13580570B3.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ICT13580570B3.Api.data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Products { get;set;}

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }
    }
}
