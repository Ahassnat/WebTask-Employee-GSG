using Microsoft.AspNetCore.Mvc;

namespace WebTask.Controller
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index(int x , int y)
        {
            var sum = x + y;
            return Ok($"The Sum: {sum}");
        }
    }
}
