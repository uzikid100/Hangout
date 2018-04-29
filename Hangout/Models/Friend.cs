using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hangout.Models
{
    public class Friend
    {
        public int FriendId { get; set; }

        [Required]
        public int UserId { get; set; }

        
    }
}
