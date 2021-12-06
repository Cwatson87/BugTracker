using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Invite
    {
        [DisplayName("Invite")]
        public int Id { get; set; }

        [DisplayName("Invite Date")]
        [DataType(DataType.Date)]
        public DateTimeOffset InviteDate { get; set; }

        [DisplayName("Join Date")]
        public DateTimeOffset JoinDate { get; set; }

        [DisplayName("Company Token")]
        public Guid CompanyToken { get; set; }

        [DisplayName("Company Id")]
        public int CompanyId { get; set; }

        [DisplayName("Project Id")]
        public int ProjectId { get; set; }

        [DisplayName("Invitor")]
        public string InvitorId { get; set; }
        
        [DisplayName("Invitee")]
        public string InviteeId { get; set; }

        [DisplayName("Invitee Email")]
        public string InviteeEmail { get; set; }

        [DisplayName("First Name")]
        public string InviteeFirstName { get; set; }

        [DisplayName("Last Name")]
        public string InviteeLastName { get; set; }

        [DisplayName("Message")]
        public string Message { get; set; }

        [DisplayName("Is valid")]
        public bool IsValid { get; set; }
        

        //--Navigation Properties--//
        public virtual Company Company { get; set; }

        public virtual BTUser Invitor { get; set; }

        public virtual BTUser Invitee { get; set; }

        public virtual Project Project { get; set; }
    }
}
