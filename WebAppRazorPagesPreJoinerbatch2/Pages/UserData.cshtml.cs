using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesPreJoinerbatch2.Models;

namespace WebAppRazorPagesPreJoinerbatch2.Pages
{
    public class UserDataModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(UserData obj) {
            TempData["name"]=obj.name;
            TempData["email"] = obj.email;
        }    
    }
}
