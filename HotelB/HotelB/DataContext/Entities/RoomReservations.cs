

namespace HotelB.DataContext.Entities
{
    public class RoomReservation
    {
        public int Id { get; set; }
        public Room Room { get; set; }
        public Reservation Reservation { get; set; }
    }
}
