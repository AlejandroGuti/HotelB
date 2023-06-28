namespace HotelB.DataContext.Entities
{
    public class Hotel
    {
        public int Id { get; set; }
        public int NIT { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
