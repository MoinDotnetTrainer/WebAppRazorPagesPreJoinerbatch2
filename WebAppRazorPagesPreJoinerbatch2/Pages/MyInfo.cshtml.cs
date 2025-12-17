using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesPreJoinerbatch2.Models;

namespace WebAppRazorPagesPreJoinerbatch2.Pages
{
    public class MyInfoModel : PageModel
    {
        [BindProperty]
        public MyInfoData _res { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            TempData["name"] = _res.Name;
            TempData["email"] = _res.Email;
        }
    }
}
