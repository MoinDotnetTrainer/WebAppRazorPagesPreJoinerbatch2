using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPagesPreJoinerbatch2.Pages
{
    public class AddModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost() {
            int x = 45, y = 46, z;
            z = x + y;
            TempData["res"] = z;
        }    
    }
}
