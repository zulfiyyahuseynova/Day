using Day.DAL;
using Day.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class AppController : Controller
    {
        private AppDbContext _context { get; }
        public AppController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
