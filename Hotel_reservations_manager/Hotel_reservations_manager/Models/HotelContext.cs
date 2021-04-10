using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_reservations_manager.Models
{
    public class HotelContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
                .HasMany(s => s.Reservations)
                .WithOne(r => r.Room)
                .HasForeignKey(f => f.RoomId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(c => c.Reservations)
                .WithOne(e => e.Client)
                .HasForeignKey(f => f.ClientId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=desktop-9ogbb5r;Database=HotelDb;Integrated Security=SSPI;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
