using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentCar.DAL;
using RentCar.Models.Entities;
using RentCar.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ContactController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(new ContactIndexViewModel { 
                Address = await _dbContext.Addresses.FirstOrDefaultAsync()
            });;
        }

        //***** Contact Form *****//
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateContactForm(ContactFormViewModel model)
        {
            ContactForm contactForm = new ContactForm
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                Phone = model.Phone,
                Message = model.Message
            };

            await _dbContext.ContactForms.AddAsync(contactForm);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index), "Contact");

        }

    }
}
