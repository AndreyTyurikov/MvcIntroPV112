using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcIntro.Models;

namespace MvcIntro.Controllers
{
    public class ImageController : Controller
    {
        // GET: ImageController
        public ActionResult Index()
        {
            return View();
        }

        [Route("ViewImage/{width}/{height}")]
        public ActionResult Show(int width, int height)
        {
            var model = new ImageViewModel { Width = width, Height = height, Format = "jpg" };

            return View(model);
        }
    }
}
