using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPagesPreJoinerbatch2.Pages
{
    public class SubModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            // request.form
            int x = Convert.ToInt32(Request.Form["txtx"]);
            int y = Convert.ToInt32(Request.Form["txty"]);
            int z;
            z = x - y;
            TempData["res"] = z;
        }
    }
}
