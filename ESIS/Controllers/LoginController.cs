using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ESIS.Models;
using Model;
using Service;

namespace ESIS.Controllers
{
    public class LoginController : Controller
    {
        UserInfoService UserInfoService = new UserInfoService();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        // GET: Login
        //[ValidateAntiForgeryToken]
        public ActionResult Index(UserBasicInputModel model)
        {
            UserInfoModel _UserInfo = new UserInfoModel();
            _UserInfo.userID = model.Account;
            _UserInfo.password = model.Password;
            Session["USERID"] = null;
            if (UserInfoService.CheckRecord(_UserInfo))
            {
                Session["USERID"] = _UserInfo.userID;

                return RedirectToAction("Index", "Home");
            }
            else
            {
                if (_UserInfo.userID != null)
                {
                    TempData["message"] = "登入嘗試失試!!";
                }
            }

            return View();
        }
    }
}