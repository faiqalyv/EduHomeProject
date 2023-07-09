using EduHome.UI.DataAccess.Context;
using EduHome.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI.Controllers
{
    public class HomeController : Controller

    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new()
            {
                courses = await _context.courses.ToListAsync(),
                notices = await _context.notices.ToListAsync()
            };
            return View(homeVM);
        }
    }
}
