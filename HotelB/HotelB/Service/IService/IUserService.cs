using HotelB.DataContext.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelB.Service
{
    public interface IUserService
    {

        Task<ActionResult<User>> GetUser(int id);




    }


}
