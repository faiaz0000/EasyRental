﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EasyRental.Models;
using System.ComponentModel.DataAnnotations;

namespace EasyRental.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }

        public MembershipType MembershipType { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Display (Name = "Membership Type ")]
        public int MembershipTypeId { get; set; }


    }
}