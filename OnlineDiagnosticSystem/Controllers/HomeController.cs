using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineDiagnosticSystem.Controllers
{
    public class HomeController : Controller
    {
        private OnlineDiagnosticLabSystemDbEntities5 db = new OnlineDiagnosticLabSystemDbEntities5();
        public ActionResult Index()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Session["UserName"])))
            {
                return RedirectToAction("Index","Home");
            }
            return View();
        }
        public ActionResult StartTamplate()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email,string password)
        {
            if(string.IsNullOrEmpty(email) && (string.IsNullOrEmpty(password)))
            {
                return View("Login");
            }
            var user = db.UserTables.Where(u => u.Email == email && u.Password == password && u.IsVerifed == true).FirstOrDefault();
            if (user != null)
            {
                Session["UserID"] = user.UserID;
                Session["UserTypeID"] = user.UserTypeID;
                Session["UserName"] = user.UserName;
                Session["Password"] = user.Password;
                Session["Email"] = user.Email;
                Session["ContactNo"] = user.ContactNo;
                Session["Description"] = user.Description;
                Session["IsVerifed"] = user.IsVerifed;
                return View("Index");
            }
            Logout();
            return View("Login");
        }
        public void Logout()
        {

            Session["UserID"] = string.Empty;
            Session["UserTypeID"] = string.Empty;
            Session["UserName"] = string.Empty;
            Session["Password"] = string.Empty;
            Session["Email"] = string.Empty;
            Session["ContactNo"] = string.Empty;
            Session["Description"] = string.Empty;
            Session["IsVerifed"] = string.Empty;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}