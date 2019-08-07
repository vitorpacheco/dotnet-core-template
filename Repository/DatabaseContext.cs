using System;
using dotnet_core_template.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace dotnet_core_template.Repository
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Value> Values { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Console.WriteLine("Contexto criado");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Console.WriteLine("Modelo criado");
        }
    }

}