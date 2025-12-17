using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesPreJoinerbatch2.Models;

namespace WebAppRazorPagesPreJoinerbatch2.Pages
{
    public class ProductModel : PageModel
    {

        [BindProperty]
        public ProductsModel _pro { get; set; }

        AppDatabase obj; // declaring
        public ProductModel()
        {
             obj = new AppDatabase();  // inili
        }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            obj.productsModels.Add(_pro);
            obj.SaveChanges();
        }
    }
}
