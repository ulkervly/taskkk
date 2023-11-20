using ALLUP2.DAL;
using ALLUP2.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ALLUP2.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var abouts = _context.Abouts.ToList();
            return View(abouts);
        }
    }
}
