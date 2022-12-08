using Microsoft.AspNetCore.Mvc;

namespace CSIMediaTechTest.Controllers
{
    public class CreateController : Controller
    {

        private readonly ILogger<CreateController> _logger;

        public CreateController(ILogger<CreateController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
