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
        public string Description { get; set; }

        [DisplayName("Created")]
        [DataType(DataType.Date)]
        public DateTimeOffset Created { get; set; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTimeOffset? StartDate { get; set; }

        [DisplayName("End Date")]
        [DataType(DataType.Date)]
        public DateTimeOffset? EndDate { get; set; }

        public int CompanyId { get; set; }
        public int ProjectPriorityId { get; set; }


        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile ImageFormFile { get; set; }

        [DisplayName("Project Image Name")]
        public string ProjectImage { get; set; }

        [DisplayName("Image File Data")]
        public byte[] ProjectImageData { get; set; }

        [DisplayName("Image File Extension")]
        public string ProjectImageType { get; set; }


        public bool Archived { get; set; }

        //--Navigation--//
        public virtual Company Company { get; set; }

        public virtual ProjectPriority ProjectPriority {get; set;}

        public virtual ICollection<BTUser> Members { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

        public virtual ICollection<Notification> Notifications { get; set; }
        
    }
}
