
using EduHome.UI.Areas.Admin.ViewModels.CourseViewModels;
using EduHome.UI.DataAccess.Context;
using EDUHome.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.UI.Areas.Admin.Controllers;

[Area("Admin")]
public class CourseController : Controller
{
    private readonly AppDbContext _context;

    public CourseController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {

        List<Course> courses = await _context.courses.Include(c => c.CourseCatagory).ToListAsync();
        return View(courses);
    }


    public async Task<IActionResult> Create()
    {
        ViewBag.Catagories = await _context.courseCatagories.ToListAsync();
        return View();
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CoursePostVM coursePost, int CatagoryId)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var catagory = _context.courseCatagories.Find(CatagoryId);

        if (catagory is null)
        {
            return BadRequest();
        }

        Course course = new();
        course.Title = coursePost.Title;
        course.Description = coursePost.Description;
        course.ImagePath = coursePost.ImagePath;
        course.CourseCatagoryId = CatagoryId;
        await _context.AddAsync(course);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }


}
