using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service;
using ESIS.Models;
using Model;

namespace ESIS.Controllers
{
    public class HomeController : Controller
    {
        Cus_CusService Cus_CusService = new Cus_CusService();

        public ActionResult Index()
        {
            if (Session["USERID"] == null)
                return Redirect("/Login/");

            return View();
        }

        [HttpPost]
        // GET: Login
        //[ValidateAntiForgeryToken]
        public ActionResult Index(CusInputModel model)
        {
            Cus_CusModel _Cus_Cus = new Cus_CusModel();
            _Cus_Cus.cus_nbr = model.CusKey;
            _Cus_Cus = Cus_CusService.GetRecords(_Cus_Cus);
            return View();
        }

        public ActionResult Ex003()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}