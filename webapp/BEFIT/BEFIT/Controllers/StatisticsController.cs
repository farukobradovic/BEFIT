using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BEFIT.Data;
using BEFIT.Models;
using BEFIT.ViewModels.Statistics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BEFIT.Controllers
{
    public class StatisticsController : Controller
    {
        private BEFITContext _context;
        private readonly UserManager<User> userManager;
        public StatisticsController(UserManager<User> userManager, BEFITContext context)
        {
            _context = context;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Calculate()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var statistics = _context.Statistic.Include(c => c.User).ToList();
            var user = await userManager.GetUserAsync(HttpContext.User);
            var statisticsFiltered = statistics.FindAll(c => c.UserID == user.Id);
            var admin = User.IsInRole("Admin");
            return View(admin ? statistics : statisticsFiltered);
        }
        [HttpPost]
        public IActionResult List(int id)
        {
            var statistic = _context.Statistic.SingleOrDefault(c => c.StatisticID == id);
            if (statistic == null)
                return StatusCode(418);
            _context.Statistic.Remove(statistic);
            _context.SaveChanges();

            return RedirectToAction("List");
        }
    }
}