using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Model
{
    // Модель продукта в магазине.
    public class Product
    {
        [Required]
        [Range(0, int.MaxValue)]
        public int ProductId { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int ProductCount { get; set; } // Количество товара в наличии.

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string ProductName { get; set; }

        [Required]
        [Column(TypeName = "varchar(60)")]
        public string ProductCompany { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string ProductCategory { get; set; } // Категория товара (Мебель, еда, etc.)

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string ProductLinkToPicture { get; set; } // Ссылка на картинку мебели в облаке.

        [Required]
        [Range(0, int.MaxValue)]
        public int ProductPrice { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int ProductDiscount { get; set; }  // Скидка на товар.
  
        [Required]
        [Column(TypeName = "varchar(400)")]
        public string ProductDescription { get; set; }
    }
}
