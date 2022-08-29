using Microsoft.AspNetCore.Mvc;

namespace ApiCielo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
      
        [HttpGet]
        public String Get()
        {
            return "Testeando a String...";
        }
    }
}