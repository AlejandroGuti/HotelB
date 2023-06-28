namespace HotelB.DataContext.Entities
{
    public class UserReservation
    {
        public int Id { get; set; }
        public Reservation Reservation { get; set; }
        public User User { get; set; }
    }
}
