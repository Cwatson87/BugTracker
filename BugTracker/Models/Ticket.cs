﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Ticket
    {
        [Required]
        [StringLength(50)]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        [StringLength(2500)]
        [DisplayName("Description")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Created")]
        public DateTimeOffset Created { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Updated")]
        public DateTimeOffset Updated { get; set; }

        [DisplayName("Archived")]
        public bool Archived { get; set; }

        [DisplayName("ArchivedByProject")]
        public bool ArchivedByProject { get; set; }

        [DisplayName("Project")]
        public int ProjectId { get; set; }

        [DisplayName("Ticket Type")]
        public string TicketTypeId { get; set; }

        [DisplayName("Ticket Status")]
        public string TicketStatusId { get; set; }

        [DisplayName("Ticket Priority")]
        public string TicketPriorityId { get; set; }

        [DisplayName("Ticket Owner")]
        public string OwnerUserId { get; set; }

        [DisplayName("Developer")]
        public string DeveloperUserId { get; set; }

        [DisplayName("Comments")]
        public string CommentId { get; set; }

        [DisplayName("Attachments")]
        public string Attachements { get; set; }

        [DisplayName("History")]
        public string HistoryId { get; set; }

        [DisplayName("Notifications")]
        public string Notification { get; set; }

        //Navigation 

        public virtual Project Project { get; set; }

        public virtual TicketType TicketType { get; set; }

        public virtual TicketPriority TicketPriority { get; set; }

        public virtual TicketStatus TicketStatus { get; set; }

        public virtual BTUser OwnerUser { get; set; }

        public virtual BTUser DeveloperUser { get; set; }


        public virtual ICollection<TicketComment> Comments { get; set; } = new HashSet<TicketComment>();

        public virtual ICollection<TicketAttachment> Attachments { get; set; } = new HashSet<TicketAttachment>();

        public virtual ICollection<Notification> Notifications { get; set; } = new HashSet<Notification>();

        public virtual ICollection<TicketHistory> History { get; set; } = new HashSet<TicketHistory>();

        public virtual ICollection<TicketTask> Task { get; set; } = new HashSet<TicketTask>();
    }
}