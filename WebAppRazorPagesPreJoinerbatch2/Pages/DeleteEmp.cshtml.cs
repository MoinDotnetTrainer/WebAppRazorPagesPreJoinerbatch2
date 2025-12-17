using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography;
using WebAppRazorPagesPreJoinerbatch2.Models;

namespace WebAppRazorPagesPreJoinerbatch2.Pages
{
    public class DeleteEmpModel : PageModel
    {
        AppDatabase _db;
        public DeleteEmpModel()
        {
            _db = new AppDatabase();
        }

        [BindProperty]
        public Employee _emp { get; set; }
        public void OnGet(int Eid)
        {
            _emp = (from s in _db.employee select s).FirstOrDefault(x => x.Eid == Eid);
        }

        public IActionResult OnPost(int Eid)
        {
            var res = _db.employee.Find(Eid);
            if (res !=null)
            {
                _db.employee.Remove(res);
                int result = _db.SaveChanges();
                if (result > 0)
                {
                    return RedirectToPage("DisplayEmployees");
                }
                else
                {
                    return Page();
                }
            }
            return Page();
        }
    }
}
