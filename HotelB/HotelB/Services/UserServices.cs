using HotelB.DataContext;
using HotelB.DataContext.Entities;
using HotelB.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelB.Services
{
    public class UserServices : IUserServices
    {
        private readonly AplicationDBContext _context;

        public UserServices(AplicationDBContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<User>> GetUser(int id)
        {
            var User = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            return User;
        //    .Include(x => x.Books).FirstOrDefaultAsync(x => x.Id == id);
        //if (autor is null)
        //    return NotFound();
        //return autor;
        }



    }


}
