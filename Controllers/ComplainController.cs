using Microsoft.AspNetCore.Mvc;

namespace OtherWise.Controllers
{
    public class ComplainController : Controller
    {
       public async Task<IActionResult>  AddComplain()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> AddComplain ()//table and dto for complain
        //{
        //    return View();
        //}

        public async Task<IActionResult> ListComplain( )
        {
            return View();
        }

    }
}
