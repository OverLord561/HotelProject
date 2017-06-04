namespace Hotel_Project
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HotelDB : DbContext
    {
        public HotelDB()
            : base("name=HotelDBContext")
        {
        }

        public virtual DbSet<Hotels> Hotels { get; set; }
        public virtual DbSet<OrdersToReservations> OrdersToReservations { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<RoomTypes> RoomTypes { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotels>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.Hotels)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rooms>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Rooms>()
                .HasMany(e => e.OrdersToReservations)
                .WithRequired(e => e.Rooms)
                .HasForeignKey(e => e.RoomID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoomTypes>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.RoomTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.OrdersToReservations)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);
        }
    }
}
