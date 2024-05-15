using Microsoft.AspNetCore.Mvc;

namespace Comparing_Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController:ControllerBase
    {
        [HttpGet]
        [Route("/getAllCars")]
        public string getAllCars(){
            return "All cars";
        }
    }
}