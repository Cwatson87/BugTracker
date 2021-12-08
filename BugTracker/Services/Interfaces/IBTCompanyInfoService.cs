using BugTracker.Data;
using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Services.Interfaces
{
   public interface IBTCompanyInfoService
    {
        public Task<List<BTUser>> GetAllMembersAsync(int companyId);

        public Task<Company> GetCompanyInfoByIdAsync(int? companyId);

        public Task<List<Project>> GetProjectsAsync(int? companyId);

        public Task<List<Ticket>> GetTicketsAsync(int? companyId);
    }
}
