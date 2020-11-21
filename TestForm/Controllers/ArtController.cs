using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestForm.Models;

namespace TestForm.Controllers
{
    public class ArtController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateArt()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateArt(CreateOrUpdate model)
        { 
            if (model.Operation == Operation.Create)
            {
                // create a new picture
            }
            else if (model.Operation == Operation.Update)
            {
                // update the existing picture by ID
            }
            else
            {
                // ...
            }
        
            return View(model);
        }
    }
}
