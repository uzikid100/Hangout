using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hangout.Models
{
    public class Event
    {
        public int EventId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Desription { get; set; }
        public DateTime? ScheduledTime { get; set; }
        public int? Capacity { get; set; }
        public double? Price { get; set; }
        public int? Attending { get; set; }
        public string Location { get; set; }

        // Must provide Foriegn key for 'author' property
        public int UserId { get; set; }

        // Reference the related table 
        public User User { get; set; }
    }
}
