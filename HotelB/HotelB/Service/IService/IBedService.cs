using HotelB.Common.DTO;
using HotelB.Common.Response;
using Microsoft.AspNetCore.Mvc;

namespace HotelB.Service

{
    public interface IBedService
    {
        Task<ActionResult<Response>> AllBedList();
        Task<ActionResult<Response>> CreateBed(CreateBed bed);
    }
}
