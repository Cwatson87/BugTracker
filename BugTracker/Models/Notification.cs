using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Notification
    {
        public int Id { get; set; }
        
        [DisplayName("Title")]
        public string NotificationId { get; set; }

        public string Message { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayName("Date")]
        public DateTimeOffset Created { get; set; }
        
        public string Viewed { get; set; }
        

        //--Navigation--//
        
        public virtual NotificationType NotificationType { get; set; }
        
        public virtual Project Project { get; set; }
        
        public virtual Ticket Ticket { get; set; }
       
        public virtual BTUser Recipent { get; set; }

        public virtual BTUser Sender { get; set; }
        
    }
}
