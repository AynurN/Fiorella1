using Fiorella1.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace Fiorella1.DAL
{
	public class AppDbContext :DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<Slide> Slides { get; set; }
		public DbSet<Product> Products { get; set; }
	}
}
