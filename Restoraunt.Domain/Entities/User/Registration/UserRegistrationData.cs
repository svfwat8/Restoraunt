﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoraunt.Domain.Entities.User.Registration
{
    public class UserRegistrationData
    {
        [Required] 
        public string UserName { get; set; }
        [Required] 
        public string Password { get; set; }
        [Required]
        public string Email { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)] 
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
