using System;
using dotnet_core_template.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace dotnet_core_template.Configurations
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Value> Values { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
    }

}