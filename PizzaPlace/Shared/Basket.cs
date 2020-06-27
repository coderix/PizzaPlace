using System.Collections.Generic;
namespace PizzaPlace.Shared
{
    public class Basket
    {
        public Customer customer { get; set; } = new Customer();
        public List<int> Orders = new List<int>();
        public bool HasPaid { get; set; } = false;
        public Basket()
        {
        }
    }
}
