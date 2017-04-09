using Microsoft.AspNetCore.Mvc;

namespace CoreWeb.Controllers
{
    [Route("")]
    public class HomeController:Controller
    {
        [HttpGet]
        public string Get()
        {
            return "It works??";
        }
    }
}
