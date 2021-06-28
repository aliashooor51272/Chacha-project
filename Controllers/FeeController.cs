using Chacha_project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chacha_project.Controllers
{
    public class FeeController : Controller
    {
        private readonly StudentContext _sa;
        public FeeController(StudentContext context)
        {
            _sa = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddFee()
        {
            return View();
        }
    }
   
  

}
