using System;

namespace _405_static_members
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public bool IsApproved { get; set; }
    }

    static class ProductManager
    {
        static Product[] Products;

        static ProductManager()
        {
            Products = new Product[5];

            Products[0] = new Product{ProductId = 1, ProductName = "Iphone 5", ProductPrice = 2000, IsApproved = false};
            Products[1] = new Product{ProductId = 2, ProductName = "Iphone 6", ProductPrice = 3000, IsApproved = false};
            Products[2] = new Product{ProductId = 3, ProductName = "Iphone 7", ProductPrice = 4000, IsApproved = true};
            Products[3] = new Product{ProductId = 4, ProductName = "Iphone 8", ProductPrice = 5000, IsApproved = true};
            Products[4] = new Product{ProductId = 5, ProductName = "Iphone X", ProductPrice = 6000, IsApproved = true};
        }
        public static Product[] GetProducts()
        {
            return Products;
        }

        public static Product GetProductById(int id)
        {
            Product product = null;

            foreach (var p in Products)
            {
                if(p.ProductId == id){
                    product = p;
                    break;
                }
            }

            return product;
        }

        public static Product GetProductByName(string name)
        {
            Product product = null;

            foreach (var p in Products)
            {
                if(p.ProductName == name){
                    product = p;
                    break;
                }
            }

            return product;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // var products = ProductManager.GetProducts();
            // foreach (var product in products)
            // {
            //     Console.WriteLine($"Id: {product.ProductId}\nName: {product.ProductName}\nPrice: {product.ProductPrice}\nActive: {product.IsApproved}");
            //     Console.WriteLine("-------------------------------");
            // }

            // var product = ProductManager.GetProductById(7);
            // Console.WriteLine($"Id: {product.ProductId}\nName: {product.ProductName}\nPrice: {product.ProductPrice}\nActive: {product.IsApproved}");
            var product = ProductManager.GetProductByName("Iphone 6");
            Console.WriteLine($"Id: {product.ProductId}\nName: {product.ProductName}\nPrice: {product.ProductPrice}\nActive: {product.IsApproved}");
        }
    }
}
