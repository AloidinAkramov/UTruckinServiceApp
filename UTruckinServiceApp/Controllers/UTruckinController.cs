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
        public async Task<ActionResult<List<Content>>> GetVehicles([FromQuery] int? count)
        {
            var vehicles = await utruckinService.GetVehiclesWithPositionAsync();
            var total = vehicles.Count;

            if (count.HasValue && count.Value > 0)
                vehicles = vehicles.Take(count.Value).ToList();

            return Ok(new
            {
                total,
                vehicles
            });
        }
    }
}