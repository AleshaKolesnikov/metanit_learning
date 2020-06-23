using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace L_02_validation_attributes
{
    public class User
    {
        [Required(ErrorMessage = "Идентификатор пользователя не установлен")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Не указано имя пользователя")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Недопустимая длина имени")]
        public string Name { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "недопустимый возраст")]
        public int Age { get; set; }

        
        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "не соответствует")]
        public string ConfirmPassword { get; set; }
    }
}
