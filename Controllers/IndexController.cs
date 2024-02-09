using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using OtherWise.Models;

namespace OtherWise.Controllers
{
    public class IndexController : Controller
    {
        private readonly AplicationDbContext DB;

        public IndexController(AplicationDbContext dB)
        {
            this.DB = dB;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
      

    }
}