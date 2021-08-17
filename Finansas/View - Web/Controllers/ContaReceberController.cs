using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View___Web.Controllers
{
    public class ContaReceberController : Controller
    {
        ContaReceberRepository repository = new ContaReceberRepository();

        public ActionResult Index()
        {
            return View();
        }
    }
}