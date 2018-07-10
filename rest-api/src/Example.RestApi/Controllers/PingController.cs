using Microsoft.AspNetCore.Mvc;

namespace Example.RestApi.Controllers
{
    public class PingController : Controller
    {
        [HttpGet("/ping")]
        public ActionResult Get() {
            return Json(new {
                Message = "pong"
            });
        }
    }
}
