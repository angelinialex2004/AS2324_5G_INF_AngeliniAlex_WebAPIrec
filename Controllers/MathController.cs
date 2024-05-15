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

        [HttpGet("CelsiusToFarenheit")]
        public JsonResult CelsiusToFarenheit(int celsius)
        {
            return new JsonResult(new
            {
                message = "Temperatura in farenheit:",
                result = (celsius * 9 / 5) + 32,
                status = "OK",
            });
        }

        [HttpGet("VolumeCylinder")]
        public JsonResult VolumeCylinder(float radius, float height)
        {
            return new JsonResult(new
            {
                message = "Il volume del cilindro è:",
                result = Math.PI * (radius * radius) * height,
                status = "OK",
            });
        }
    }
}
