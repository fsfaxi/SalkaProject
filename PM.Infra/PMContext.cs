using System;
using Microsoft.EntityFrameworkCore;
using PM.Domain.Models;

namespace PM.Infra
{
    public class PMContext : DbContext
    {
        public PMContext(DbContextOptions<PMContext> options)
            : base(options)
        {
        }

        public DbSet<PackageItem> PackageItems { get; set; }
    }
}