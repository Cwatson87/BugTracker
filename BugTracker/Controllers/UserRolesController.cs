using BugTracker.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Controllers
{
    public class UserRolesController : Controller
    {
        private readonly IBTRolesService _rolesService;

        public UserRolesController(IBTRolesService rolesService)
        {
            _rolesService = rolesService;
        }

        [HttpGet]
        public async Task<IActionResult> ManageUserRoles()
        {
            //Add a instance of the ViewModel
            //get all company users

            //loop over the users to populate the viewmodel
            // - instantiate ViewModel
            //  - use _roleservice
            //create multi-selects

            //return  the model to the view
        }





        [HttpPost]
        public Task<IActionResult> ManagerUserRoles([ViewModel])
        {
            //Instantiate the BTUser
            // Get Roles for the User
            //Remove User from their roles

            //Grab the selected role

            // Add User to the new role

            //Navigate back to View
        }
    }
}
 