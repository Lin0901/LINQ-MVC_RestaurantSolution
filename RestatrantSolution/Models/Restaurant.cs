namespace RestatrantSolution.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public static int IdCount { get; set; }
        public string Name { get; set; }
        public List<RestaurantItem> Inventory { get; set; }
        public List<Order> Orders { get; set; }
        public static List<Restaurant> AllRestaurants { get; set; }

        public Restaurant(string name)
        {
            Id = IdCount++;
            Name = name;
            Inventory = new List<RestaurantItem>();
            Orders = new List<Order>();      
        }
        static Restaurant()
        {
            AllRestaurants = new List<Restaurant>();
        }
       
    }
}
