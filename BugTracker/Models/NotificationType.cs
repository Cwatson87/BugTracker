using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class NotificationType
    {

        public int Id { get; set; }

        [Required]
        [DisplayName("Type Name")]
        public string Name { get; set; }
    }
}
