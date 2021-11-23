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
    public class Company
    {
        public int Id { get; set; }
                
        [DisplayName("Company Name")]
        public string Name { get; set; }

        [DisplayName("Company Description")]
        [StringLength(2500)]
        public string description { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile ImageFormFile { get; set; }

        [DisplayName("Image Name")]
        public string ImageFileName { get; set; }

        [DisplayName("Company Image")]
        public byte[] ImageFileData { get; set; }

        [DisplayName("Image Extension")]
        public byte[] ImageContentType { get; set; }


        public virtual ICollection<BTUser> Members { get; set; } = new HashSet<BTUser>();

        public virtual ICollection<Project> Projects { get; set; } = new HashSet<Project>();

        public virtual ICollection<Invite> Invites { get; set; } = new HashSet<Invite>();
    }
}
