using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hangout.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public int? Repuation { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        public string Avatar { get; set; }
        public bool? IsAuthenticated { get; set; }


        public ICollection<Friend> Friends { get; set; }
    }
}
