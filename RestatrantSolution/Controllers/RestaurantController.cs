using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestatrantSolution.Models;

namespace RestatrantSolution.Controllers7
{
    public class RestaurantController : Controller
    {
        public RestaurantController()
        {
            Customer customer1 = new Customer("Customer1");
            Customer customer2 = new Customer("Customer2");
            Customer customer3 = new Customer("Customer3");
            Customer customer4 = new Customer("Customer4");
            Customer customer5 = new Customer("Customer5");
            Customer customer6 = new Customer("Customer6");

            if (!Customer.AllCustomers.Any())
            {
                Customer.AllCustomers.Add(customer1);
                Customer.AllCustomers.Add(customer2);
                Customer.AllCustomers.Add(customer3);
                Customer.AllCustomers.Add(customer4);
                Customer.AllCustomers.Add(customer5);
                Customer.AllCustomers.Add(customer6);
            }

            Item item1 = new Item("Chicken", 15);
            Item item2 = new Item("Beef", 15);
            Item item3 = new Item("Lamb", 16);
            Item item4 = new Item("Vegetable", 5);
            Item item5 = new Item("Coke", 2);
            Item item6 = new Item("Sushi", 7);

            if (!Item.AllItems.Any())
            {
                Item.AllItems.Add(item1);
                Item.AllItems.Add(item2);
                Item.AllItems.Add(item3);
                Item.AllItems.Add(item4);
                Item.AllItems.Add(item5);
                Item.AllItems.Add(item6);
            }
        }
        public IActionResult Index()
        {
            return View();
        }

        // GET /restaurant/selectcustomer
        public IActionResult SelectCustomer() //第一种列表写法
        {
            var newSelectList = new SelectList(Customer.AllCustomers, "Id", "UserName");

            return View(newSelectList);
        }

        // GET /restaurant/selectrestaurant/customerid
        public IActionResult SelectRestaurant(int customerId)
        {
            Customer customer = Customer.AllCustomers.First(c => c.Id == customerId);
            return View(customer);
        }

        public IActionResult SelectItems() // 重新另一种 列表写法 拆开写
        {
            var itemWithPrices = Item.AllItems.Select(i => new
            {
                // select into a new Display property that shows if an item is out of stock
                id = i.Id,
                display = $"{i.Name} (${i.DollarValue})",
                valueItem = i.DollarValue > Item.AllItems.Average(j => j.DollarValue)
            });

            var newSelectItem = new SelectList(itemWithPrices, "id", "display","valueItem");

            return View(newSelectItem);
        }
    }
}
