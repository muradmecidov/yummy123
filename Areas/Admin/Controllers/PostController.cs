using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Areas.Admin.ViewModels;
using WebApplication2.DAL;
using WebApplication2.Models;

namespace WebApplication2.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class PostController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostEnvironment _environment;

        public PostController(AppDbContext context, IHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            ICollection<Post> posts= await _context.Posts.ToListAsync();
            return View(posts);
        }

        public  IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create(PostVM model)
        {
            try
            {
                this._context.Add(model);
                this._context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public async Task<IActionResult> Update(PostVM model)
        {

            return View(model);
        }
    }
}
