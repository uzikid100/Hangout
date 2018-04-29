using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangout.Models;
using Microsoft.EntityFrameworkCore;

namespace Hangout.Database
{
    public class HangoutContext: DbContext
    {
        public HangoutContext(DbContextOptions<HangoutContext> options)
            :base(options)
        {}

        public DbSet<User> Users { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Event> Events { get; set; }

        // Any additional configuration for specified DbSet<T>:
    }
}
