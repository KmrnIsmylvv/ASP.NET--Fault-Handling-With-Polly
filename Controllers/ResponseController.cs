using Microsoft.AspNetCore.Mvc;

namespace ResponseService.Controllers
{
    public class ResponseController : BaseApiController
    {
        [Route("{id:int}")]
        [HttpGet]
        public IActionResult GetAResponse(int id)
        {
            Random rnd = new Random();
            int rndInteger = rnd.Next(1, 101);
            if (rndInteger >= id)
            {
                Console.WriteLine("--> Failure - Generate a HTTP 500");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            Console.WriteLine("--> Success - Generate a HTTP 200");
            return Ok();
        }
    }
}