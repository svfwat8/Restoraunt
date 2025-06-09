﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Restoraunt.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Телефон")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required, StringLength(30, MinimumLength = 5)]
        public string UserName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required, MinLength(6), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password), Compare("Password",
            ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}