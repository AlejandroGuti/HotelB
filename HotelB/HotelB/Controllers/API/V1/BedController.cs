using HotelB.Common.Response;
using HotelB.Service;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace HotelB.Controllers.API.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class BedController: ControllerBase
    {
        private readonly IBedService _bedService;

        public BedController(IBedService bedService)
        {
            _bedService = bedService;
        }

        [HttpGet("GetAllBeds")]
        public async Task<IActionResult> GetAllBeds()
        {
            try
            {
                var response = await _bedService.AllBedList();
                if(response.Value.IsSuccess == false)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(response);
                }

               // return Ok (await _bedService.AllBedList());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        //[HttpPost]
        //public async Task<IActionResult> CreateBed()
        //{

        //}
    }
}
