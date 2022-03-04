using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CARSDATASET.Models
{
    public partial class CARSDATASETContext : DbContext
    {
        public CARSDATASETContext()
        {
        }

        public CARSDATASETContext(DbContextOptions<CARSDATASETContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress; Data Source=desktop-kibbs2e;Initial Catalog=CARSDATASET;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("cars");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Am).HasColumnName("am");

                entity.Property(e => e.CarModel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Carb).HasColumnName("carb");

                entity.Property(e => e.Cyl).HasColumnName("cyl");

                entity.Property(e => e.Disp).HasColumnName("disp");

                entity.Property(e => e.Drat).HasColumnName("drat");

                entity.Property(e => e.Gear).HasColumnName("gear");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.Mpg).HasColumnName("mpg");

                entity.Property(e => e.Qsec).HasColumnName("qsec");

                entity.Property(e => e.Vs).HasColumnName("vs");

                entity.Property(e => e.Wt).HasColumnName("wt");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
