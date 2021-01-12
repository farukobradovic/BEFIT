using BEFIT.Data;
using BEFIT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BEFIT.Controllers
{
    [Authorize]
    public class NotificationController : Controller
    {
        private readonly BEFITContext ct;

        public NotificationController(BEFITContext ct)
        {
            this.ct = ct;
        }

        public IActionResult Index()
        {
            List<Notification> listaObavijesti = ct.Notification.OrderByDescending(x=>x.NotificationID).ToList();
            return View(listaObavijesti);
        }



        [HttpGet]
        public IActionResult AddNotification()
        {
            return View("AddNotification", new Notification());
        }

        [HttpPost]
        public IActionResult AddNotification(Notification notification)
        {
            if (!ModelState.IsValid)
              return View("AddNotification", notification);

            //ct.Notification.Add(notification);
            //ct.SaveChanges();
            //return RedirectToAction("Index","Notification");

            if (notification.NotificationID == 0)
                ct.Notification.Add(notification);
            else
            {
                var notificationInDb = ct.Notification.Single(n => n.NotificationID == notification.NotificationID);
                notificationInDb.NotificationName = notification.NotificationName;
                notificationInDb.NotificationContent = notification.NotificationContent;
            }

            ct.SaveChanges();
            return RedirectToAction("Index", "Notification");
        }

        public IActionResult DisplayNotification(int id)
        {
            var n = ct.Notification.Where(x => x.NotificationID == id).FirstOrDefault();
            if (n == null)
                return StatusCode(418);
            return View(n);
        }
        [HttpPost]
        public IActionResult DisplayNotification(Notification notification)
        {    


            ct.Update(notification);
            ct.SaveChanges();

            return RedirectToAction("Index", "Notification");
        }
        public IActionResult EditNotification(int id)
        {

            Notification n = ct.Notification.Where(x => x.NotificationID == id).FirstOrDefault();

            return View(n);

        }

        [HttpPost]
        public IActionResult EditNotification(Notification notification, int id)
        {
            
            var obj = ct.Notification.SingleOrDefault(c => c.NotificationID == id);
            if (obj == null)
                return StatusCode(418);
            obj.NotificationName = notification.NotificationName;
            obj.NotificationContent = notification.NotificationContent;


            //ct.Update(notification);

            ct.SaveChanges();
           
            
            return RedirectToAction("Index", "Notification");

        }
        public IActionResult DeleteNotification(int id)
        {
            Notification n = ct.Notification.Where(x => x.NotificationID == id).FirstOrDefault();
            ct.Notification.Remove(n);
            ct.SaveChanges();

            return RedirectToAction(nameof(Index));

        }

    }
}
