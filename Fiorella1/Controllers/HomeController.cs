using Fiorella1.DAL;
using Fiorella1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiorella1.Controllers
{
	public class HomeController : Controller
	{
		AppDbContext _context;
		public HomeController(AppDbContext context)
		{
			_context = context;
		}
		
		public async Task<IActionResult> Index()
		{
			HomeVM homeVM = new HomeVM()
			{
				Slides = await _context.Slides.OrderBy(x => x.Order).Take(2).ToListAsync(),
				Products = await _context.Products
				.Include(x => x.ProductImages.Where(i => i.isPrimary != null))
				.OrderByDescending(p => p.CreatedAt)
				.Take(8)
				.ToListAsync()
			};

			return View(homeVM);
		}
	}
}
