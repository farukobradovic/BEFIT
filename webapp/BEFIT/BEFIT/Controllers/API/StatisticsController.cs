using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BEFIT.Data;
using BEFIT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BEFIT.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        private BEFITContext _context;
        public StatisticsController(BEFITContext context, UserManager<User> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }

        [HttpGet("{height}/{weight}")]
        public async Task<ActionResult<Statistic>> CalculateBMI(double height, double weight)
        {
            double calculateBMI = weight / (height * height);
            var user = await userManager.GetUserAsync(HttpContext.User);
            var statistics = _context.Statistic.ToList();
            double statisticAverage = 0;
            if(statistics.Count() != 0)
            {
                foreach (var i in statistics)
                {
                    statisticAverage += i.CalculatedBMI;
                }
                statisticAverage /= statistics.Count();
            };


            var statistic = new Statistic
            {
                DateCalculated = DateTime.Now,
                UserID = user.Id,
                Height = height,
                WeightInKilos = weight,
                CalculatedBMI = calculateBMI,
                AverageBMI = statisticAverage
            };

            _context.Statistic.Add(statistic);
            _context.SaveChanges();
            

            return Ok(statistic);
        }
    }
}