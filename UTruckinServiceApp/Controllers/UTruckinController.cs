using Microsoft.AspNetCore.Mvc;
using UTruckinServiceApp.Models;
using UTruckinServiceApp.Services;

namespace UTruckinServiceApp.Controllers
{
    [ApiController]
    [Route("api/utruckin")]
    public class UTruckinController : ControllerBase
    {
        private readonly IUtruckinService utruckinService;

        public UTruckinController(IUtruckinService utruckinService)
        {
            this.utruckinService = utruckinService;
        }

        [HttpGet("get-all-orders")]
        public async Task<ActionResult<List<Content>>> GetVehicles(
            [FromQuery] int page = 0,
            [FromQuery] int size = 10)
        {
            var vehicles = await utruckinService.GetVehiclesWithPositionAsync(page, size);
            return Ok(vehicles);
        }
    }
}