namespace HotelB.DataContext.Entities
{
    public class RoomBed
    {
        public int Id { get; set; }
        public Bed Bed { get; set; }
        public Room Room { get; set; }

        public int Quatity { get; set; }
        public bool IsActive { get; set; }
    }
}
