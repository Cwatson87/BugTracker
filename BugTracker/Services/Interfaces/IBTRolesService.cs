using BugTracker.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugTracker.Services.Interfaces
{
    interface IBTRolesService
    {
        public Task<bool> AddUserToRolesAsync(BTUser user, string roleName);

        public Task<List<IdentityRole>> GetRolesAsync();

        public Task<string> GetRoleNameByIdAsync(string roleId);

        public Task<List<BTUser>> GetUsersInRoleAsync(string roleName, int companyId);

        public Task<List<BTUser>> GetUsersNotInRoleAsync(string roleName, int companyId);

        public Task<IEnumerable<string>> GetUserRolesAsync(BTUser user);

        public Task<bool> IsUserInROleAsync(BTUser user, string roleName);

        public Task<bool> RemoveUserFromRoleAsync(BTUser user, string roleName);

        public Task<bool> RemoverUserFromRolesAsync(BTUser user, IEnumerable<string> roles);
    }
}
