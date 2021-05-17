using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PR.Models;

namespace PR.Controllers
{
    public class HomeController : Controller
    {

       public static string pega;
        public ActionResult Index(string pt)
        {
            // DXCOMMENT: Pass a data model for GridView
            pega = Request.Url.Segments.Last();
            return View();
        }
     
      
    
    }
}