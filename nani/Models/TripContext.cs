using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace nani.Models
{
    public partial class TripContext : DbContext
    {
        public TripContext() : base()
        {
        }

        public TripContext(DbContextOptions<TripContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Train100rows> Train100rows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Train100rows>(entity =>
            {
                entity.ToTable("train100rows", "trainDB");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DropoffDatetime)
                    .HasColumnName("dropoff_datetime")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DropoffLatitude).HasColumnName("dropoff_latitude");

                entity.Property(e => e.DropoffLongitude).HasColumnName("dropoff_longitude");

                entity.Property(e => e.PassengerCount)
                    .HasColumnName("passenger_count")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PickupDatetime)
                    .HasColumnName("pickup_datetime")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PickupLatitude).HasColumnName("pickup_latitude");

                entity.Property(e => e.PickupLongitude).HasColumnName("pickup_longitude");

                entity.Property(e => e.StoreAndFwdFlag)
                    .HasColumnName("store_and_fwd_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TripDuration)
                    .HasColumnName("trip_duration")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendor_id")
                    .HasColumnType("int(11)");
            });
        }
    }
}
