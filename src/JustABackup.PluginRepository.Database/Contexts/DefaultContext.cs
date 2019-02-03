using JustABackup.PluginRepository.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JustABackup.PluginRepository.Database.Contexts
{
    public class DefaultContext : DbContext
    {
        public DbSet<PluginEntry> Plugins { get; set; }

        public DbSet<PluginVersion> Versions { get; set; }

        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
