namespace SEDC.PizzaApp.Models
{
    public class Order
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public decimal OrderCost { get; set; }

        public decimal Discount { get; set; }

        public string Address { get; set; }
    }
}
