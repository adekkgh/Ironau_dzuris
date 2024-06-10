using Ironau_Dzuris.Db;
using Ironau_Dzuris.Helpers;
using System;
using System.ComponentModel.DataAnnotations;

namespace Ironau_Dzuris.Models
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

        [Required(ErrorMessage = "Введите пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Придумайте пароль")]
        [RegularExpression("^(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?])[A-Za-z\\d!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]*$", ErrorMessage = "Пароль должен содержать хотя бы один спецсимвол, цифру и заглавную букву")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Пароль должен содержать минимум 8 символов")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Подтвердите пароль")]
        [Compare("NewPassword", ErrorMessage = "Это не совпадает с выбранным вами паролем")]
        public string NewPasswordConfirmation { get; set; }
    }
}
