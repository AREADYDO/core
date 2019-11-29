using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ContantController : Controller
    {
        public IActionResult Index()
        {
            var contants = new List<Contant>();
            for (int i = 1; i < 11; i++)
            {
                contants.Add(new Contant { Id = i, title = $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-i) });
            }
            return View(new ContantViewModel { Contants=contants});
        }
    }
}