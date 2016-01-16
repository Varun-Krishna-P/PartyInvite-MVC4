using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInviteMVC4.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter the name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the email address.")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter the valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you will attend")]
        public bool? WillAttend { get; set; }
    }
}