using System.ComponentModel.DataAnnotations;
namespace PizzaPlace.Shared
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public Customer()
        {
        }
    }
}
