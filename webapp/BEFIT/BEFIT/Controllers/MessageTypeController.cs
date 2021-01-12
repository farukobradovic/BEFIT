using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BEFIT.Data;
using BEFIT.Models;
using BEFIT.ViewModels.MessageType;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BEFIT.Controllers
{
    [Authorize(Roles = "Admin")]
    public class MessageTypeController : Controller
    {
        private readonly UserManager<User> userManager;
        private BEFITContext _context;

        public MessageTypeController(UserManager<User> userManager, BEFITContext context)
        {
            this.userManager = userManager;
            _context = context;

        }
        [HttpGet]
        public IActionResult Display()
        {
            var types = _context.MessageType.ToList();
            return View(types);
        }
        [HttpPost]
        public IActionResult Display(int id)
        {
            var type = _context.MessageType.SingleOrDefault(c => c.ID == id);
            if (type == null)
                return StatusCode(418);
            _context.MessageType.Remove(type);
            _context.SaveChanges();

            return RedirectToAction("Display");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateMessageTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var messageType = new MessageType
                {
                      Description = model.Name
                };
                _context.MessageType.Add(messageType);
                _context.SaveChanges();
                return RedirectToAction("Display", "MessageType");
            }
            return View(model);
        }
    }
}