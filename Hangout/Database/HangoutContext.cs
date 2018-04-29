using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangout.Models;
using Hangout.Models.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Hangout.Database
{
    public class HangoutContext: DbContext, IUnitOfWork
    {
        public HangoutContext(DbContextOptions<HangoutContext> options)
            :base(options)
        {}

        public DbSet<User> Users { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Event> Events { get; set; }

        // Any additional configuration for specified DbSet<T>:
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureUsers(modelBuilder);
        }

        private void ConfigureUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(s => s.Id)
                .UseSqlServerIdentityColumn();

            modelBuilder.Entity<User>()
                .HasIndex(s => s.Username)
                .IsUnique();
        }
    }
}
