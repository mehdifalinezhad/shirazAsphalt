using Microsoft.AspNetCore.Mvc;
using OtherWise.Models;
using System.Net;


namespace OtherWise.Controllers
{
    public class ShopController : Controller
    {
        private readonly AplicationDbContext DB;

        public ShopController(AplicationDbContext dB)
        {
            this.DB = dB;
        }

        public async Task<IActionResult> ListShop()
        {


            return View();
        }
        public async Task<IActionResult> DbLoder()
        {
            var protoadd = new Product()
            {
                Description = " نمنمتمنتمنتمنتیبدصعردسیعهبدرسهعبردبسردسهعدسهرعدسهبیدر",
                picUrl = "192.186.1.1",
                Price = "1200039",
                Name = "siman",
                Mountatain="everest"


                };
               DB.productdb.Add(protoadd);
            DB.SaveChanges();
            var protoadd2 = new Product()
            {
                Description = " نمنمتمنتمنتمنتیبدصعردسیعهبدرسهعبردبسردسهعدسهرعدسهبیدر",
                picUrl = "192.186.1.1",
                Price = "1200039",
                Name = "siman",
                Mountatain = "everest"


            };
            DB.productdb.Add(protoadd2);
            DB.SaveChanges();
            return RedirectToAction("ListShop");
            

        }
    }
}