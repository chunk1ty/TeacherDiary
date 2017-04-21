﻿using System.ComponentModel.DataAnnotations;

namespace TeacherDiary.Clients.Mvc.ViewModels.Account
{
    public class RegisterViewModel
    {        
        [Required(ErrorMessage = "Имeйла е задължителен.")]
        [EmailAddress(ErrorMessage = "Невалиден имейл формат.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Паролата е задължителна.")]
        [StringLength(100, ErrorMessage = "Паролата трябва да е с дължина минимум {2} символа.", MinimumLength = 6)]
        [DataType(DataType.Password)]        
        public string Password { get; set; }

        [DataType(DataType.Password)]       
        [Compare("Password", ErrorMessage = "Паролата несъвпада.")]
        public string ConfirmPassword { get; set; }
    }
}