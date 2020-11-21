using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestForm.Models;

namespace TestForm.Controllers
{
    public class AccountController : Controller
    {
        //GET: Account
        public IActionResult Login()
        {
            return View();
        }

        //primitive model binding
        //[HttpPost]
        //public ContentResult Login(string username, string password)
        //{
        //    if (username == "Esin" && password == "tiger")
        //    {
        //        return Content("Hoşgeldin Esin");
        //    }
        //    else if (username != "Esin" && password == "tiger")
        //    {
        //        return Content("Kullanıcı adınızı yanlış girdiniz. Tekrar deneyiniz.");
        //    }
        //    else if (username == "Esin" && password != "tiger")
        //    {
        //        return Content("Parolanızı yanlış girdiniz. Tekrar deneyiniz.");
        //    }
        //    else
        //    {
        //        return Content("Üzgünüz parolanızı veya kullanıcı adınızı yanlış girdiniz. Tekrar deneyiniz. ");
        //    }
        //}

        //complex Model Binding
        [HttpPost]
        public ContentResult Login(User model)
        {
            if (model.Username == "Esin" && model.Password == "tiger")
            {
                return Content(" Hoşgeldin " + model.Username);
            }
            else if (model.Username != "Esin" && model.Password == "tiger")
            {
                return Content("Kullanıcı adınızı yanlış girdiniz. Tekrar deneyiniz.");
            }
            else if (model.Username == "Esin" && model.Password != "tiger")
            {
                return Content("Parolanızı yanlış girdiniz. Tekrar deneyiniz.");
            }
            else
            {
                return Content("Üzgünüz parolanızı veya kullanıcı adınızı yanlış girdiniz. Tekrar deneyiniz. ");
            }
        }

    }
}
