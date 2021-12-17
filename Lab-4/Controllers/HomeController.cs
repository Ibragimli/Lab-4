using Lab_4.Models;
using Lab_4.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_4.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Clients = _context.Clients.ToList(),
                Services = _context.Services.ToList(),
                Categories = _context.Categories.ToList(),
                Portfolios = _context.Portfolios.ToList(),
                PortfolioSliders = _context.portfolioSliders.ToList(),
            };
            return View(homeVM);
        }
    }
}
