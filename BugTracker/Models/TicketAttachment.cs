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
    public class TicketAttachment
    {
        public int Id { get; set; }

        public int TicketId { get; set; }

        [DisplayName("Ticket Task")]
        public int? TicketTaskId { get; set; }
        
        [Required]
        public string UserId { get; set; }
        
        [Display(Name = "Attachment Date")]
        [DataType(DataType.Date)]
        public DateTimeOffset Created { get; set; }

        [DisplayName("Attachement Description")]
        public string Description { get; set; }

        [NotMapped]
        [DisplayName("Please select a file")]
        [DataType(DataType.Upload)]
        public IFormFile FormFile { get; set; }

        [DisplayName("File Name")]
        public string FileName { get; set; }
        public byte[] FileData { get; set; }

        [DisplayName("File Extenstion")]
        public string FileContentType { get; set; }

        //--Navigational--//

        public virtual Ticket Ticket { get; set; }

        public virtual BTUser User { get; set; }
    }
}
