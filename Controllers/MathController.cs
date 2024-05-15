using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace AS2324_5G_INF_AngeliniAlex_WebAPIrec.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();


        }
        [HttpGet("celsius_to_farenheit")]
        public JsonResult celsius_to_farenheit(int celsius)
        {
            return new JsonResult(new
            {
                message = "Temperatura in farenheit:",
                result = (celsius * 9 / 5) + 32,
                status = "OK"
            });
        }

        [HttpGet("volume_cylinder")]
        public JsonResult volume_cylinder(float radius, float height)
        {
            return new JsonResult(new
            {
                message = "Il volume del cilindro è:",
                result = Math.PI * (radius * radius) * height,
                status = "OK"
            });
        }
    }
}
