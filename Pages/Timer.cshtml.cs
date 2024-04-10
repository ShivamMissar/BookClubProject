using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookclub.Pages
{
    public class TimerModel : PageModel
    {

        [Authorize(Roles = "Member")]
        public void OnGet()
        {
        }
    }
}
