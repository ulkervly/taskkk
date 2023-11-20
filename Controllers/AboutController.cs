using ALLUP2.DAL;
using ALLUP2.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ALLUP2.Controllers
{
    public class AboutController:Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            AboutViewModel homevm = new AboutViewModel()
            {
                Abouts = _context.Abouts.ToList(),

            };

            return View(homevm);
        }
    }
}
