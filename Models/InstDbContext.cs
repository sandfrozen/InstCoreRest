using System;
using Microsoft.EntityFrameworkCore;

namespace InstCoreRest.Models
{
    public class InstDbContext : DbContext
    {
        public InstDbContext(DbContextOptions<InstDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
