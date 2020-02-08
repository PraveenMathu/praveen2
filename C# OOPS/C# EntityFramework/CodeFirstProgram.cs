using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Codefirstprogramdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDBContext context = new CustomerDBContext();

            //var orders = context.Orders;

            //var order1 = orders.Add(new Order()
            //{
            //    OrderID = 1,
            //    OrderDate = new DateTime(2020, 01, 01),
            //    CustomerID = 1,
            //    ShippedDate = new DateTime(2020, 01, 15)
            //});

            //var order2 = orders.Add(new Order()
            //{
            //    OrderID = 2,
            //    OrderDate = new DateTime(2020, 01, 01),
            //    CustomerID = 2,
            //    ShippedDate = new DateTime(2020, 01, 15)
            //});

            //var order3 = orders.Add(new Order()
            //{
            //    OrderID = 3,
            //    OrderDate = new DateTime(2020, 01, 01),
            //    CustomerID = 3,
            //    ShippedDate = new DateTime(2020, 01, 15)
            //});

            var Customer = context.Customers;
            var customer1 = Customer.Add(new Customer()
            {
                CustomerID = 1,
                Name = "riki",
                Address = "no.10, 3rd main",
                Country = "INDIAN"

            });

            context.SaveChanges();
        }
        public class CustomerDBContext : DbContext
        {
            public CustomerDBContext() : base("Name = CustomerDBContext")
            {

            }
            public DbSet<Order> Orders { get; set; }
            public DbSet<Customer> Customers { get; set; }

        }

        public class Order
        {
            public int OrderID { get; set; }
            public DateTime OrderDate { get; set; }
            public int CustomerID { get; set; }
            public DateTime ShippedDate { get; set; }
        }

        public class Customer
        {
            public int CustomerID { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Country { get; set; }

        }
    }
}