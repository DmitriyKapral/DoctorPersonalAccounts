using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalDoctors.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDoctors.Controllers
{
    public class HomeController : Controller
    {
        DoctorContext db;
        public HomeController(DoctorContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.patients.ToList());
        }
/*        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.phoneid = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.orders.Add(order);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо, " + order.users + ", за покупку!";
        }*/
    }
}
