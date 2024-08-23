using Fiorella1.Models.Base;

namespace Fiorella1.Models
{
	public class ProductImage :BaseModel
	{
		public string ImageURL { get; set; }
		public bool? isPrimary { get; set; }
		//relational
		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}
