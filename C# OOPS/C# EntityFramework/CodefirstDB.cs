using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace codefirstDB
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDBContext context = new ProductDBContext();
            var prd = context.Products;
            var product1 = prd.Add(new product() { ProductID = 1, Name = "Badham Milk", Price = 99.99, Quantity = "500ml" });

            var product2 = prd.Add(new product() { ProductID = 2, Name = "Praveen Milk", Price = 199.99, Quantity = "500ml" });

            var product3 = prd.Add(new product() { ProductID = 3, Name = "Rose Milk", Price = 49.99, Quantity = "500ml" });

            var cat = context.Categories;

            var cat1 = cat.Add(new Category() { CategoryID = 1, Name = "Reverages" });

            context.SaveChanges();


        }
    }

    public class ProductDBContext : DbContext
    {
        public ProductDBContext() : base("name=ProductDBContext")
        { }

        public DbSet<product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

    public class product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Quantity { get; set; }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }

}
}
