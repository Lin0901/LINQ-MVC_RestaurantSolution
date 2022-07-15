namespace RestatrantSolution.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public static int IdCount { get; set; } = 0;
        public string UserName { get; set; }
        public static List<Customer> AllCustomers { get; set; }
        public List<Order> Orders { get; set; }
        public Customer(string userName)
        {
            Id = IdCount++;
            UserName = userName;
            Orders = new List<Order>();
        }
        static Customer()
        {
            AllCustomers = new List<Customer>();
        }
    }

}
