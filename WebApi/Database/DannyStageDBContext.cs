using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DevOpsProject.Database
{
    public partial class DannyStageDBContext : DbContext
    {
        public DannyStageDBContext()
        {
        }

        public DannyStageDBContext(DbContextOptions<DannyStageDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Names> Names { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=192.168.1.108;Database=DannyStageDB;User ID=danny;Password=danny;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Names>(entity =>
            {
                entity.HasKey(e => e.NameId);

                entity.Property(e => e.NameLength).IsRequired();
            });
        }
    }
}
