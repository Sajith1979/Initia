using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProfileApp.Models;

namespace ProfileApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            
            PageVariables pVariables = new PageVariables();
            pVariables.Environment = ConfigurationManager.AppSettings["Environment"].ToString();
            pVariables.HarborKey = ConfigurationManager.AppSettings["MY_HARBOR_KEY"].ToString();
            pVariables.TestKey = ConfigurationManager.AppSettings["TEST_KEY"].ToString();
            pVariables.UniqueKey = ConfigurationManager.AppSettings["UNIQUE_KEY"].ToString();
            //Test comment.
            return View("VariableView", pVariables);
        }

    }
}
