﻿using System;
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
        public string Email { get; set; }
        public string Phone { get; set; }
        public  bool?  WillAttend{ get; set; }
    }
}