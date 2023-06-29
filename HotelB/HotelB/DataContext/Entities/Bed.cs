using System.Security.Principal;

namespace HotelB.DataContext.Entities
{
    public class Bed
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Size { get; set; }

        //public Room Room { get; set; }
        public bool IsActive { get; set; }
        public string Mark { get; set; }
        public bool Warranty { get; set; }
        public DateTime BuyDate { get; set; }
        public DateTime WExpDate { get; set; }

        public ICollection<RoomBed> RoomBed { get; set; }

    }
}
