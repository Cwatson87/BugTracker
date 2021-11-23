using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        [StringLength (50)]
        [DisplayName("Project Name")]
        public string Name { get; set; }

        [DisplayName("Description")]
        [StringLength (2500)]
        public string description { get; set; }

        [DisplayName("Created")]
        [DataType(DataType.Date)]
        public DateTimeOffset created { get; set; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTimeOffset startDate { get; set; }

        [DisplayName("End Date")]
        [DataType(DataType.Date)]
        public DateTimeOffset endDate { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile ImageFormFile { get; set; }

        [DisplayName("Project Image")]
        public string projectImage { get; set; }

        [DisplayName("File Extension")]
        public byte[] ImagefileData { get; set; }


        public bool Archived { get; set; }

        //--Navigation--//
        public virtual Company Company { get; set; }

        public virtual ProjectPriority projectPriority {get; set;}

        public virtual ICollection<BTUser> Members { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

        public virtual ICollection<Notification> Notifications { get; set; }
        
    }
}
