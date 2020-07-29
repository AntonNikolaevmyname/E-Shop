using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Model
{
    // Модель заказа в магазине.
    public class Order
    {
        [Required]
        [Range(0, int.MaxValue)]
        public int OrderId { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string OrderAddress { get; set; } // Адрес покупателя.

        public DateTime OrderBeginDateTime { get; set; } // Дата и время заказа.
        public DateTime OrderEndDateTime { get; set; } // Дата и время доставки.

        [Required]
        [Range(0, int.MaxValue)]
        public int ProductId { get; set; } // Ссылка на связанную модель Product.

        [Required]
        [Range(0, int.MaxValue)]
        public int ProductCountInOrder { get; set; } // Количество заказанного товара (штук).

        [Required]
        public Product Product { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int UserId { get; set; } // Ссылка на связанную модель Customer.

        [Required]
        public User User { get; set; }
    }
}
