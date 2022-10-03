using Microsoft.AspNetCore.Mvc;

namespace ResponseService.Controllers
{
    public class ResponseController : BaseApiController
    {
        [Route("{id:int}")]
        [HttpGet]
        public IActionResult GetAResponse(int id)
        {
            return Ok();
        }
    }
}