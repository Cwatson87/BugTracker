using BugTracker.Data;
using BugTracker.Models;
using BugTracker.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Services
{
    public class BTRoleService : IBTRolesService
    {
        
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<BTUser> _userManager;
        private readonly ApplicationDbContext _context;

        public BTRoleService(RoleManager<IdentityRole> roleManager, UserManager<BTUser> userManager, ApplicationDbContext context)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
        }

        public async Task<bool> AddUserToRolesAsync(BTUser user, string roleName)
        {
            try
            {
                bool result = (await _userManager.AddToRoleAsync(user, roleName)).Succeeded;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> GetRoleNameByIdAsync(string roleId)
        {
            try
            {
                IdentityRole role = _context.Roles.Find(roleId);
                string result = await _roleManager.GetRoleNameAsync(role);

                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public async Task<List<IdentityRole>> GetRolesAsync()
        {
            try
            {
                List<IdentityRole> result = new List<IdentityRole>();

                result = await _context.Roles.ToListAsync();
            }
            catch (System.Exception)
            {
                throw;
            }            
            

        public async Task<IEnumerable<string>> GetUserRolesAsync(BTUser user)
        {
                try
                {
                    IEnumerable<string> result = await _userManager.GetRolesAsync(user);

                    return result;
                 }
                catch (System.Exception)
                {
                    throw;
                }
        }

        public async Task<List<BTUser>> GetUsersInRoleAsync(string roleName, int companyId)
        {
                try
                {
                    List<BTUser> users = (await _userManager.GetUsersInRoleAsync(roleName)).ToList();
                    List<BTUser> result = users.Where(u => u.CompanyId == companyId).ToList();

                    return result;
                }
        }

        public Task<List<BTUser>> GetUsersNotInRoleAsync(string roleName, int companyId)
        {   
                //TODO: Come back
            throw new NotImplementedException();
        }

        public async Task<bool> IsUserInROleAsync(BTUser user, string roleName)
            {
                try
                {
                    bool result = await _userManager.IsInRoleAsync(user, roleName);
                    return result;
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
              

        public async Task<bool> RemoverUserFromRoleAsync(BTUser user, IEnumerable<string> roles)
        {
                try
                {
                    bool result = await _userManager.RemoveFromRoleAsync(user, roleName).Succeeded;
                    return result;
                }
                catch (System.Exception)
                {
                    throw;
                }
            }

        public async Task<bool> RemoveUserFromRolesAsync(BTUser user, string roleName)
        {
           try
                {
                    bool result = await _userManager.RemoveFromRolesAsync(user, roles).Succeeded;
                    return result;
                }
                catch (System.Exception)
                {

                }
        }
    }

        public Task<IEnumerable<string>> GetUserRolesAsync(BTUser user)
        {
            throw new NotImplementedException();
        }

        public Task<List<BTUser>> GetUsersInRoleAsync(string roleName, int companyId)
        {
            throw new NotImplementedException();
        }

        public Task<List<BTUser>> GetUsersNotInRoleAsync(string roleName, int companyId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUserInROleAsync(BTUser user, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoverUserFromRolesAsync(BTUser user, IEnumerable<string> roles)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveUserFromRoleAsync(BTUser user, string roleName)
        {
            throw new NotImplementedException();
        }
    }
