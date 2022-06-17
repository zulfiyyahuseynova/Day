using Day.DAL;
using Day.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Apps = await _context.Apps.ToListAsync(),
                Cards = await _context.Cards.ToListAsync(),
                Webs = await _context.Webs.ToListAsync()
            };
            return View(homeVM);
        }
    }
}
