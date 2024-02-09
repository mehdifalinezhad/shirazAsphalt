using Microsoft.AspNetCore.Mvc;

namespace OtherWise.Controllers
{
    public class AboutController : Controller
    {
        public async Task<IActionResult> ShowAboutUs()
        {
        
            return View();
        
        }
    
    
    }
}
