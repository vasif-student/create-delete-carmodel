using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentCar.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Controllers
{
    public class PartnerController : Controller
    {
        private readonly AppDbContext _dbContext;

        public PartnerController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _dbContext.PartnerInfoCards.ToListAsync());
        }
    }
}
