namespace HotelB.DataContext.Entities
{
    public class Bill
    {
        public int Id { get; set; }
        public Reservation Reservation { get; set; }
    }
}
