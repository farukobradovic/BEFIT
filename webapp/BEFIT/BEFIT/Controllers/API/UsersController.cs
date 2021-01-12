using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BEFIT.Data;
using BEFIT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BEFIT.Controllers.API
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private BEFITContext _context;
        public UsersController(BEFITContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return _context.Users.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(string id)
        {
            var user = _context.Users.SingleOrDefault(c => c.Id == id);
            if (user == null)
                return new NotFoundResult();
            return Ok(user);
        }
    }
}