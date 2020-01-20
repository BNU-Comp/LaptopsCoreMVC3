using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LaptopsCoreMVC.Models;
using LaptopsCoreMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace LaptopsCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        // GET: Laptops
        public async Task<IActionResult> Laptops()
        {
            return View(await _context.Laptop.ToListAsync());
        }

        // GET: Customers/Details/5
        [Authorized]
        public async Task<IActionResult> MyAccount()
        {
            var email = User.Identity.Name;

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.EmailAddress == email);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
