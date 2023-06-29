using HotelB.DataContext;
using HotelB.DataContext.Entities;
using HotelB.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelB.Service
{
    public class UserService : IUserService
    {
        private readonly ApplicationDBContext _context;

        public UserService(ApplicationDBContext context)
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
