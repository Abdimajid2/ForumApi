using ForumApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ForumApi.DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
    }
}
