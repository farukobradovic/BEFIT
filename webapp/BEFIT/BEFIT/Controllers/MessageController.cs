using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BEFIT.Data;
using BEFIT.Models;
using BEFIT.ViewModels.Message;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BEFIT.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        private readonly UserManager<User> userManager;
        private BEFITContext _context;

        public MessageController(UserManager<User> userManager, BEFITContext context)
        {
            this.userManager = userManager;
            _context = context;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult List()
        {
            var messages = _context.Message.Include(c => c.User).Include(c => c.Type).ToList();
            messages.Reverse();
            return View(messages);
        }

        [HttpGet]
        public IActionResult Create(string id)
        {
            var types = _context.MessageType.ToList();
            List<string> typeNames = new List<string>();
            foreach(var t in types)
            {
                typeNames.Add(t.Description);
            }
            var user = _context.Users.SingleOrDefault(c => c.Id == id);
            if (user == null)
                return StatusCode(418);

            var model = new CreateMessageViewModel
            {
                TypeNames = typeNames,
                User = user
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateMessageViewModel model, string id)
        {
            if (ModelState.IsValid)
            {
                var messageType = _context.MessageType.SingleOrDefault(c => c.Description == model.Type);
                if (messageType == null)
                    return StatusCode(418);

                var message = new Message
                {
                    DateCreated = DateTime.Now,
                   TypeID = messageType.ID,
                   Title = model.Title,
                   Description = model.Description,
                   UserID = id,
                   Resolved = false
                };
                _context.Message.Add(message);
                _context.SaveChanges();
                return RedirectToAction("Index", "Notification");
            }

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Display(int id)
        {
            var message = _context.Message.Include(c => c.User).Include(c => c.Type).SingleOrDefault(c => c.ID == id);
            if (message == null)
                return StatusCode(418);


            return View(message);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Display(int id, int m)
        {
            var message = _context.Message.Include(c => c.User).Include(c => c.Type).SingleOrDefault(c => c.ID == id);
            if (message == null)
                return StatusCode(418);

            message.Resolved = true;
            message.DateResolved = DateTime.Now;
            _context.SaveChanges();

            return RedirectToAction("List");
        }
    }
}