using Fiorella1.Models.Base;

namespace Fiorella1.Models
{
	public class Slide :BaseModel
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public int Order { get; set; }
	}
}
