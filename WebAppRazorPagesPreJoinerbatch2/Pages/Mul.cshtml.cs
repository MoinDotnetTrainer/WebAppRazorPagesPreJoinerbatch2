using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPagesPreJoinerbatch2.Pages
{
    public class MulModel : PageModel
    {
        [BindProperty]
        public int txtx { get; set; }

        [BindProperty]
        public int txty { get; set; }
        public void OnGet(){

        }

        public void OnPost() {
            int z = txtx * txty;
            TempData["res"] = z;
        }    
    }
}
