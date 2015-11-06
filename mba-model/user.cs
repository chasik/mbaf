﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mba_model
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "Login")]
        public string Login { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "User E-Mail")]
        public string Email { get; set; }
        [Display(Name = "User Photo")]
        public byte[] Photo { get; set; }

        public virtual List<Role> Roles { get; set; }
    }
}