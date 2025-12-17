using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesPreJoinerbatch2.Models;

namespace WebAppRazorPagesPreJoinerbatch2.Pages
{
    public class DisplayEmployeesModel : PageModel
    {
        AppDatabase _db;
        public DisplayEmployeesModel()
        {
            _db = new AppDatabase();
        }

        public IList<Employee> emp { get; set; }
        public void OnGet()
        {
            emp = (from s in _db.employee  select s).ToList();
        }
    }
}
