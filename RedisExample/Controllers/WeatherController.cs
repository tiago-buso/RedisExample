using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RedisExample.Controllers
{
    public class WeatherController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }       
    }
}
