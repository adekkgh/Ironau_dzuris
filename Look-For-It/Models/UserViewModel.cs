﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Look_For_It.Models
{
    public class UserViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите свое имя")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Пожалуйста, введите свое настоящее имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите свою электоронную почту")]
        [EmailAddress(ErrorMessage = "Пожалуйста, введите подлинную электоронную почту")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Неверный пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Придумайте пароль")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Подтвердите пароль")]
        [Compare("NewPassword", ErrorMessage = "Это не совпадает с выбранным вами паролем")]
        public string NewPasswordConfirmation { get; set; }
    }
}
