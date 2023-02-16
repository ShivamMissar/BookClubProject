using Bookclub.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Bookclub.Pages
{
    public class UserManagementModel : PageModel
    {


        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IEnumerable<IdentityRole> Roles { get; set; }

        public IEnumerable<AppUser> Users { get; set; }

        [BindProperty]
        public string newRoleName { get; set; }

        [BindProperty]
        public string newPassword { get; set; }
        [BindProperty]
        public string updateRoleName { get; set; }

        public UserManagementModel(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;

           
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Roles = await _roleManager.Roles.ToListAsync();
           
            Users = await _userManager.Users.ToListAsync();
            
            return Page();
        }

        public async Task<IActionResult> OnGetDelete(string Id)
        {
            var roleToDelete = await _roleManager.FindByIdAsync(Id);
            var result = await _roleManager.DeleteAsync(roleToDelete);
            return RedirectToPage("/UserManagement");
        }

        // With this function whatever the user has entered within the input field, it will go here and create a new role. With the trim function it will only take in what is relavent
        public async Task<IActionResult> OnPostCreation()
        {
            await _roleManager.CreateAsync(new IdentityRole(newRoleName));
            return RedirectToPage("/UserManagement");

        }
        //this function will update the users current role with a new role which is valid
        public async Task <IActionResult> OnPostUpdateRoleAsync(string Id)
        {
            // first find the user
            var roleToChange = await _userManager.FindByIdAsync(Id);

            // if the role does not exist then it will return the admin elsehwhere.
            var findUser = await _userManager.FindByIdAsync(Id);
            if(!await _roleManager.RoleExistsAsync(updateRoleName))
            {
                return RedirectToPage("/Index");
            }
            else
            {
                // it will update the users current role.
                await _userManager.AddToRoleAsync(findUser, updateRoleName);
                return RedirectToPage("/UserManagement");
            }
        }
        // this will remove the user from the website and the database.
        public async Task <IActionResult> OnGetDeleteUserAsync(string Id)
        {
            var findUser = await _userManager.FindByIdAsync(Id);
            var removeUser = await _userManager.DeleteAsync(findUser);
            return RedirectToPage("/UserManagement");
        }

        // this will remove the users current password and then be updated to a new password which is entered on the site.
        public async Task <IActionResult> OnPostUpdatePasswordAsync(string Id)
        {
            var findUser = await _userManager.FindByIdAsync(Id);
            await _userManager.RemovePasswordAsync(findUser);
            await _userManager.AddPasswordAsync(findUser, newPassword);
            return RedirectToPage("/UserManagement");
        }
    }


    
}

