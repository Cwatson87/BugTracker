using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class TicketComment
    {
        public int Id { get; set; }

        [DisplayName("Memeber Comment")]
        public string Comment { get; set; }

        [DisplayName("Comment Date")]
        [DataType(DataType.Date)]

        public DateTimeOffset Created { get; set; }

        [DisplayName("Ticket")]
        public int TicketId { get; set; }

        [DisplayName("Team Member")]
        public string UserId { get; set; }

        //--Navigation Properties--//

        public virtual Ticket Ticket { get; set; }

        public virtual BTUser User { get; set; }

    }
}
