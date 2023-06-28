using HotelB.DataContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelB.DataContext
{
    public class AplicationDBContext:DbContext
    {
        public AplicationDBContext (DbContextOptions options ): base(options)
        {
        }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomReservation> RoomReservations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserReservation> UserReservations { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

    }
}
