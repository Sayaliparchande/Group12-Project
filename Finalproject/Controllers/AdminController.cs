using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class AdminController : Controller
    {
        BurgerDbContext dbContext = new BurgerDbContext();

        [Route("api/admin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Admin>>> GetProducts()
        {
            return await dbContext.Admins.ToListAsync();
        }
    }
}
