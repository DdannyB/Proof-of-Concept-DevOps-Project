using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApi.Models;

namespace WebApi.Database
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

        public virtual DbSet<DataBasePerson> DBperson { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<DataBasePerson>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name);

                entity.Property(e => e.Age);

            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name);

            });


        }
    }
}
