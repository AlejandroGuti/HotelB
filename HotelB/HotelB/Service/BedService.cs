
using HotelB.Common.Response;
using HotelB.DataContext;
using HotelB.DataContext.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelB.Service
{
    public class BedService : IBedService
    {
        private readonly ApplicationDBContext _context;

        public BedService(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<Response>> AllBedList()
        {

            List<Bed> response = await _context.Beds.ToListAsync();

            if (response.Count == 0)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Not found"
                };

            } else 
            { return new Response
                {
                    IsSuccess = true,
                    Message = "Ok",
                    Result = response
                };

            }

        }
    }
}
