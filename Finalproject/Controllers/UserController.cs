using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    /*[Route("api/[controller]")]
    [ApiController]*/
    public class UserController : Controller
    {
        BurgerDbContext dbContext = new BurgerDbContext();

         [Route("api/user")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SignupUser>>> GetProducts()
        {
            return await dbContext.SignupUsers.ToListAsync();
        }

         [Route("api/adduser")]
        [HttpPost]
        public IActionResult Create(SignupUser newuser)
        {
            dbContext.SignupUsers.Add(newuser);
            dbContext.SaveChanges();
            return Ok();
        }

    }
}
