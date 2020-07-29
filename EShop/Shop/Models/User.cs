using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model
{
    // Модель покупателя.
    public class User
    {
        [Required]
        [Range(0, int.MaxValue)]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string UserRole { get; set; } // Роль пользователя. (admin, moderator, user)

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string UserEmail { get; set; } // Почта пользователя.

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string UserPassword { get; set; } // Пароль пользователя.

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string UserContactPhone { get; set; } // Контактный телефон пользователя.
    }
}
