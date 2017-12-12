using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FindDragDrop2.Models.Entities
{
    public partial class FindDragDropContext : DbContext
    {
        public virtual DbSet<Item> Item { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=finddragdrop.database.windows.net;Initial Catalog=FindDragDropDB;Integrated Security=False;User ID=fridaochsimona;Password=Simona_Frida!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("Item", "fdd");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Word)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WordLv)
                    .HasColumnName("WordLV")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WordSe)
                    .HasColumnName("WordSE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
