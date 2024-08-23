using Fiorella1.Models.Base;

namespace Fiorella1.Models
{
	public class Product :BaseModel
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
		public string Description { get; set; }
		public string SKU { get; set; }
        //relational
        public ICollection<ProductImage>? ProductImages { get; set; }
    }
}
