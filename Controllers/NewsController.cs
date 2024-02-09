using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using OtherWise.Models;

namespace OtherWise.Controllers
{
    public class NewsController : Controller
    {
        private readonly AplicationDbContext DB;

        public NewsController(AplicationDbContext dB)
        {
            this.DB = dB;
        }

        public async Task<IActionResult> ListNews()
        {
            return View();

        }


        public async Task<IActionResult> NewsLoader()
        {

            var news=new News() 
            {
            Name="anywho",
            Description="doing over time",
           
            
            };

            DB.newsdb.Add(news);
            DB.SaveChanges();

            var news2 = new News()
            {
                Name = "anywssho",
                Description = "doing ovasasasser time",


            };

            DB.newsdb.Add(news2);
            DB.SaveChanges();
            return RedirectToAction("ListNews");

        }





    }
}
