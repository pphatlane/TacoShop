using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TacoShop.Web
{
    public class ShopController : Controller
    {
        // GET: HomeController
        public ActionResult shop()
        {
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }


    }
}
