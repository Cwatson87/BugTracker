using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models.ViewModels
{
    public class DashbaordViewModel
    {
        public Company Company { get; set; }

        public List<Project> Projects { get; set; }

        public List<Ticket> Ticket { get; set; }

        public List<BTUser> Members { get; set; }
    }
}
