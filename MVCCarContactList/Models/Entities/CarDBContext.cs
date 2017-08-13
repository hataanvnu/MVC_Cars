using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MVCCarContactList.Models.ViewModels;

namespace MVCCarContactList.Models.Entities
{
    public partial class CarDBContext : DbContext
    {
        public virtual DbSet<Car> Car { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Brand).HasMaxLength(20);
            });
        }


    }
}