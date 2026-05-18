using AgriCulturePresantationNew.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriCulturePresantationNew.Controllers
{
    public class ChartController : Controller
    {
       // entity kısmına product diye kleyp sonra contexte e ekleyip migration yap sonra dal ve busines siçin ayrı ayrı
       // product service manager dal ef oluştur ve bunun altında IProductsERVİCEYİ tanımla ve cons al en sonda ındex içinde 
       //@product. propun neyse prudct name ve value onu yap bitti dinamik grafiğik oldu 

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ProductChart()
        {
            List<ProductClass> productClasesses = new List<ProductClass>();
            productClasesses.Add(new ProductClass 
            {
                productname = "Buğday",
             productvalue = 850
            });
            productClasesses.Add(new ProductClass 
            {
             productname = "Mercimek",
             productvalue = 480
            });
            productClasesses.Add(new ProductClass 
            {
             productname = "Arpa",
             productvalue = 250
            });
            productClasesses.Add(new ProductClass 
            {
             productname = "Pirinç",
             productvalue = 120
            });
            productClasesses.Add(new ProductClass 
            {
             productname = "Domates",
             productvalue = 960
            });


            return Json(new { Jsonlist = productClasesses });
        }
    }
}
