using Microsoft.AspNetCore.Mvc;
using UTruckinServiceApp.Models;
using UTruckinServiceApp.Services;

namespace UTruckinServiceApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UTruckinController : ControllerBase
    {
        private readonly IUTruckinService utruckinService;

        public UTruckinController(IUTruckinService utruckinService)
        {
            this.utruckinService = utruckinService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Content>>> GetVehicles()
        {
            var vehicles = await utruckinService.GetVehiclesWithPositionAsync();

            return Ok(vehicles);
        }
    }
}