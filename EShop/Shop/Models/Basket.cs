using Shop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    // Модель корзины с товарами покупателя.
    public class Basket
    {
        [Required]
        [Range(0, int.MaxValue)]
        public int BasketId { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int ProductId { get; set; } // Ссылка на связанную модель Product.

        [Required]
        [Range(0, int.MaxValue)]
        public int ProductCountInBasket { get; set; } // Количество в корзине товара (штук).

        [Required]
        public Product Product { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int CustomerId { get; set; } // Ссылка на связанную модель Customer.

        [Required]
        public Customer Customer { get; set; }
    }
}
