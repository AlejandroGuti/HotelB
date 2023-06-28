namespace HotelB.DataContext.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public ICollection <UserReservation> UserReservations { get; set; }
        public ICollection<RoomReservation> RoomReservations { get; set; }
    }
}
