using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using W5_cafe.Models;

namespace W5_cafe.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();        
        public ActionResult Index()
        {
            ViewData["combo"] = db.comboes.OrderByDescending(k => k.name).ToList();
            List<product> lstPro = db.products.OrderByDescending(k => k.name).ToList();
            return View(lstPro);
        }        

    }
}