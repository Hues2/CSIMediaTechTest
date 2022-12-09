using Microsoft.AspNetCore.Mvc;
using CSIMediaTechTest.Models;

namespace CSIMediaTechTest.Controllers
{
    public class CreateController : Controller
    {

        private readonly ILogger<CreateController> _logger;

        private Entry newEntry = new Entry();

        public CreateController(ILogger<CreateController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(newEntry);
        }

     
    }
}
