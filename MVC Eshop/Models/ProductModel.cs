using System.ComponentModel;

namespace MVC_Eshop.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; } = "";
        [DisplayName("Product Description")]
        public string Description { get; set; } = "";
        [DisplayName("Product Price")]
        public string Price { get; set; } = "";

    }
}
