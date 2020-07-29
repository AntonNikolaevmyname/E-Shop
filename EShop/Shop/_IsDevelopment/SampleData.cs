using System.Linq;
using Shop.Model;

namespace Shop._IsDevelopment
{
    public static class SampleData
    {
        public static void Initialize(ShopContext context)
        {
            if (!context.Products.Any())
            {
                /*
                context.Products.AddRange(
                    new Product
                    {
                        ProductCount = 30,
                        ProductName = "Bogdan",
                        ProductCompany = "Bogdan inc.",
                        ProductCategory = "Armchair",
                        ProductLinkToPicture = "https://clubsamodelok.ru/wp-content/uploads/2018/03/Stul-svoimi-rukami-10.jpg",
                        ProductPrice = 1000,
                        ProductDiscount = 0,
                        ProductDescription = "An ordinary chair."
                    },
                    new Product
                    {
                        ProductCount = 60,
                        ProductName = "Arman",
                        ProductCompany = "Arman inc.",
                        ProductCategory = "Sofa",
                        ProductLinkToPicture = "https://clubsamodelok.ru/wp-content/uploads/2018/03/Stul-svoimi-rukami-10.jpg",
                        ProductPrice = 500,
                        ProductDiscount = 10,
                        ProductDescription = "An ordinary sofa."
                    },
                    new Product
                    {
                        ProductCount = 90,
                        ProductName = "Yuri",
                        ProductCompany = "Yuri inc.",
                        ProductCategory = "Table",
                        ProductLinkToPicture = "https://clubsamodelok.ru/wp-content/uploads/2018/03/Stul-svoimi-rukami-10.jpg",
                        ProductPrice = 250,
                        ProductDiscount = 50,
                        ProductDescription = "An ordinary table."
                    }
                );*/
                context.SaveChanges();
            }
        }
    }
}
