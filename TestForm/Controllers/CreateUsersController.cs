using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestForm.Models;

namespace TestForm.Controllers
{
    public class CreateUsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateNewAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewAccount(CreateNewUser model)
        {
                if (model.Operations == Operations.Create)
                {
                    // create a new account
                }
                else if (model.Operations == Operations.Update)
                {
                    // update the existing account by ID
                }
                else
                {
                    // ...
                }

                return View(model);
            
        }
    }

}
