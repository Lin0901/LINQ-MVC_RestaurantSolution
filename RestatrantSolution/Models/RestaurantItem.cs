namespace RestatrantSolution.Models
{
    public class RestaurantItem
    {
        public Restaurant Restaurant { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }

        public RestaurantItem(Restaurant restaurant, Item item, int quantity)
        {
            Restaurant = restaurant;
            Item = item;
            Quantity = quantity;
        }

    }
}
