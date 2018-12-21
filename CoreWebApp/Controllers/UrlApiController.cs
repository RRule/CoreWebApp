using Microsoft.AspNetCore.Mvc;

namespace CoreWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrlApiController : ControllerBase
    {
        public IActionResult Add()
        {
            return Ok("Ok!");
        }
    }
}