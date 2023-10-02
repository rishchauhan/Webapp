using Microsoft.AspNetCore.Mvc.RazorPages;
using Webapp.Services;
using Webapp.Model;

namespace Webapp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products;
        public void OnGet()
        {
            ProductService productService = new ProductService();
            Products = productService.GetProducts();

        }
    }
}