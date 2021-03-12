using Microsoft.AspNetCore.Mvc;
using API.Data;
using System.Collections.Generic;
using API.Models;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public ActionResult<IEnumerable<AppUser>> GetUser()
        {
            var users = _context.Users.ToList();
            return users;
        }

        [HttpGet("{id}")]

        public ActionResult<AppUser> GetUser(int id)
        {
            return _context.Users.Find(id);
        }
    }
}