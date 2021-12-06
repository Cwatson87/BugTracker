using BugTracker.Extensions;
using BugTracker.Models;
using BugTracker.Models.ViewModels;
using BugTracker.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserRolesController : Controller
    {
        private readonly IBTRolesService _rolesService;
        private readonly IBTCompanyInfoService _companyInfoService;
        private readonly UserManager<BTUser> _userManager;

        public UserRolesController(IBTRolesService rolesService,
                                   IBTCompanyInfoService companyInforService,
                                   UserManager<BTUser> userManager)
        {
            _rolesService = rolesService;
            _companyInfoService = companyInforService;
            _userManager = userManager;
        }



        [HttpGet]
        public async Task<IActionResult> ManageUserRoles()
        {
            //Add a instance of the ViewModel
            List<ManageUserRolesViewModel> model = new List<ManageUserRolesViewModel>();

            //Get CompanyId
            int companyId = User.Identity.GetCompanyId().Value;

            //get all company users
            List<BTUser> users = await _companyInfoService.GetAllMembersAsync(companyId);


            //loop over the users to populate the viewmodel
            // - instantiate ViewModel
            //  - use _roleservice
            //create multi-selects
            foreach (BTUser user in users)
            {
                ManageUserRolesViewModel viewModel = new ManageUserRolesViewModel();
                viewModel.BTUser = user;
                IEnumerable<string> selected = await _rolesService.GetUserRolesAsync(user);
                viewModel.Roles = new MultiSelectList(await _rolesService.GetRolesAsync(), "Name", "Name", selected);

                model.Add(viewModel);
            }
            //return  the model to the view
            return View(model);


        }





        [HttpPost]
        public async Task<IActionResult> ManageUserRoles(ManageUserRolesViewModel member)
        {
            int companyId = User.Identity.GetCompanyId().Value;

            //Instantiate the BTUser
            BTUser btUser = (await _companyInfoService.GetAllMembersAsync(companyId)).FirstOrDefault(u => u.Id == member.BTUser.Id);

            // Get Roles for the User

            IEnumerable<string> roles = await _rolesService.GetUserRolesAsync(btUser);

            string userRole = member.SelectedRoles.FirstOrDefault();

            if (!string.IsNullOrEmpty(member.SelectedRoles.FirstOrDefault()))
            {

                //Remove User from their roles
                if (await _rolesService.RemoverUserFromRolesAsync(btUser, roles))
                {
                    //Grab the selected role



                    // Add User to the new role
                    await _rolesService.AddUserToRolesAsync(btUser, userRole);

                }

            }
                //Navigate back to View
                return RedirectToAction(nameof(ManageUserRoles));

        }
    }
}
 