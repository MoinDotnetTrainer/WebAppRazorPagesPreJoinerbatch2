using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesPreJoinerbatch2.Models;

namespace WebAppRazorPagesPreJoinerbatch2.Pages
{
    public class DivModel : PageModel
    {
        [BindProperty]
        public Myprop _myvalues { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            int z = _myvalues.txtx / _myvalues.txty;
            TempData["res"] = z;
        }
    }
}
