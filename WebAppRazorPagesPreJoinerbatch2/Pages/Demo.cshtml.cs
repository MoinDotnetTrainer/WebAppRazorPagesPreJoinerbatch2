using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPagesPreJoinerbatch2.Pages
{
    public class DemoModel : PageModel
    {
        public void OnGet() // somethings which runs on page load
        {
            TempData["res"] = System.DateTime.Now.ToLongTimeString();
        }

        public void OnPost() // somethings which runs on click event
        {
            TempData["res"] = "Postback at " + System.DateTime.Now.ToLongTimeString();
        }
    }
}
