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
        public AddEmployeeModel() {
            obj = new AppDatabase();
        }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            obj.employee.Add(_Emp);  // insert is done
            obj.SaveChanges();
            // _Emp we haev data here
            // Insert
        }
    }
}
