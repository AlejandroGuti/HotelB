using HotelB.DataContext.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelB.Services.IServices
{
    public interface IUserServices
    {
        Task<ActionResult<User>> GetUser(int id);
    }
}
