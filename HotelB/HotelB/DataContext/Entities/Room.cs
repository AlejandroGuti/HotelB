namespace HotelB.DataContext.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Bathroom { get; set; }
        public bool IsActive { get; set; }
        public ICollection <Bed> Beds { get; set; }
        public ICollection<RoomReservation> RoomReservations { get; set; }
        //public Hotel Hotel { get; set; }
    }
}
