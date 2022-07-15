namespace RestatrantSolution.Models
{
    public class Item
    {
        public int Id { get; set; }
        public static int IdCount { get; set; }
        public string Name { get; set; }
        public int DollarValue { get; set; }
        public List<RestaurantItem> Inventories { get; set; }
        public static List<Item> AllItems { get; set; }

        public Item(string name, int dollarValue)
        {
            Id = IdCount++;
            Name = name;
            DollarValue = dollarValue;
            Inventories = new List<RestaurantItem>();
        }
        static Item()
        {
            AllItems = new List<Item>();
        }
    }
}
