using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesPreJoinerbatch2.Models;

namespace WebAppRazorPagesPreJoinerbatch2.Pages
{
    public class AddEmployeeModel : PageModel
    {
        [BindProperty]
        public Employee _Emp { get; set; }

        AppDatabase obj;
        public AddEmployeeModel()
        {
            obj = new AppDatabase();
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            obj.employee.Add(_Emp);  // insert is done
            int res = obj.SaveChanges();  // 1 0
            if (res > 0)
            {
                return RedirectToPage("DisplayEmployees");
            }
            else
            {
                return Page();
            }
            // _Emp we haev data here
            // Insert
        }
    }
}
