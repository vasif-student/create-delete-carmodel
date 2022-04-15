using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentCar.Areas.Admin.Models.ViewModel;
using RentCar.DAL;
using RentCar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = RoleConstants.Admin)]
    public class DashboardController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        public DashboardController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            IdentityUser user = await _userManager.GetUserAsync(User);
            return View(new DashboardIndexViewModel { 
                User = user
            });
        }
    }
}
