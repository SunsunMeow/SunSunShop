using SunSun.Data.Infrastructure;
using SunSun.Model.Models;
using SunSun.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SunSun.Web.Areas.Admin.Controllers
{
    
    public class AccountController : Controller
    {
        // GET: Admin/Account
        private UnitOfWork unitOfWork = new UnitOfWork();
        private SunSunDbContext db = new SunSunDbContext();
   
        public ActionResult Login()
        {
            if (!Session["UserAdmin"].Equals(""))
            {
                return RedirectToAction("Index", "Dashboard");
            }
            ViewBag.Error = "";           
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            string error = "";

            string email = form["email"];
            string password = form["password"];

            Account account = db.Accounts
                .Where(m=>m.Status == true && m.RoleID == 1 && (m.Email == email))
                .FirstOrDefault();
           
            if (account == null)
            {
                error = "Email does not exist!";
            }
            else
            {
                if(account.Password.Equals(password))
                {
                    Session["UserAdmin"] = account.Email;
                    Session["AccountID"] = account.ID;
                    Session["Fullname"] = account.FullName;

                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    error = "Password is not correct!";
                }
            }
            
            ViewBag.Error ="<span class='text-danger'>"+error+"</span>";
            return View();
        }
        public ActionResult Logout()
        {
            Session["UserAdmin"] = "";
            Session["AccountID"] = "";
            Session["Fullname"] = "";

            return RedirectToAction("Login", "Account");
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(AccountVM account)
        {
            if(ModelState.IsValid)
            {
                var check = db.Accounts.FirstOrDefault(s=> s.Email == account.Email);
                if (check == null)
                {

                    var user = new Account()
                    {
                        Email = account.Email,
                        Password = account.Password,
                        Phone = account.Phone,
                        FullName = account.FullName,
                        RoleID = 1,
                        CreatedDate= DateTime.Now,
                    };
                    unitOfWork.AccountRepository.Add(user);
                    unitOfWork.Save();
                    
                    return RedirectToAction("Login", "Account");
                }
            }
            else
            {
                ModelState.AddModelError("New Error","Invalid Data");
                return View();
            }
            return RedirectToAction("Login", "Account");
        }
        public ActionResult Index()
        {
            var list = unitOfWork.AccountRepository.GetAll().ToList();
            return View(list);
        }

    }
}