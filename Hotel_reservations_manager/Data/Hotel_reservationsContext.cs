using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    class Hotel_reservationsContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(a => a.Reservation)
                .WithOne(b =>b.idUser)
                .HasForeignKey(e=>e.UserId);

            modelBuilder.Entity<Room>()
                .HasMany(a => a.Reservation)
                .WithOne(b => b.numberRoom)
                .HasForeignKey(e => e.RoomNumber);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectV13\Initial Catalog=hotel_reservation;password=26082002");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
