using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Model
{
    // Заказ покупателя в магазине.
    public class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; } // Имя фамилия покупателя.
        public string Address { get; set; } // Адрес покупателя.
        public string ContactPhone { get; set; } // Контактный телефон покупателя.

        public int PhoneId { get; set; } // Ссылка на связанную модель Product.
        public Product Product { get; set; }
    }
}
