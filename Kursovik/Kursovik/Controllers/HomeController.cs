using Kursovik.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovik.Controllers
{
    public class HomeController : Controller
    {
        private readonly UsersContext db;
        public HomeController(UsersContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            //return Content(User.Identity.Name);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Messeng(Messange mess)
        {
            if (mess != null)
            {
                try
                {
                    db.Messengs.Add(mess);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                catch
                {
                    ViewBag.Error = "Ошибка отправки сообщения";
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Error = "Ошибка отправки сообщения";
            return RedirectToAction("Index");
        }
    }
}
