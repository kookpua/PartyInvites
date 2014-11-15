using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter emaill address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "please enter a calid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter attend")]
        public bool? WillAttend { get; set; }
    }
}