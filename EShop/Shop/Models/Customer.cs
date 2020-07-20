using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Model
{
    // Модель покупателя.
    public class Customer
    {
        [Required]
        [Range(0, int.MaxValue)]
        public int CustomerId { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string CustomerEmail { get; set; } // Почта покупателя.

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string CustomerPassword { get; set; } // Пароль покупателя.

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CustomerContactPhone { get; set; } // Контактный телефон покупателя.
    }
}
