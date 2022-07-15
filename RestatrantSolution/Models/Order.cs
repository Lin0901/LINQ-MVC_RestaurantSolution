namespace RestatrantSolution.Models
{
    public class Order
    {
        public int Id { get; set; }
        public static int IdCount { get; set; }
        public string OrderName { get; set; }
        public static List<Order> AllOrders { get; set; }

        public Order(string orderName)
        {
            Id = IdCount++;
            OrderName = orderName; 
        }
        static Order()
        {
            AllOrders = new List<Order>();
        }
    }
}
