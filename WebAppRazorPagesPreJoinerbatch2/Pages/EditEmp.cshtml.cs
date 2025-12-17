using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesPreJoinerbatch2.Models;

namespace WebAppRazorPagesPreJoinerbatch2.Pages
{
    public class EditEmpModel : PageModel
    {
        AppDatabase _db;
        public EditEmpModel()
        {
            _db = new AppDatabase();
        }

        [BindProperty]
        public Employee _emp { get; set; }
        public void OnGet(int Eid)
        {
            _emp = (from s in _db.employee select s).FirstOrDefault(x => x.Eid == Eid);
        }

        public IActionResult OnPost() {
            _db.Attach(_emp).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            int res = _db.SaveChanges();
            if (res > 0)
            {
                return RedirectToPage("DisplayEmployees");
            }
            else
            {
                return Page();
            }
        }
    }
}
