using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using abc_of_asp.net_mvc.Models;
namespace abc_of_asp.net_mvc.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /Default1/

        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult abc2()
        {
            ViewData["CurrentDatetime"] = DateTime.Now.ToString();
            return View();
        }

        public ActionResult abc3()
        {
            Customer objCustomer = new Customer();
            objCustomer.Code = "12";
            objCustomer.Name = "nisar";
            objCustomer.Amount = 9990.34;
            return View("abc3", objCustomer);
        }


    }
}
