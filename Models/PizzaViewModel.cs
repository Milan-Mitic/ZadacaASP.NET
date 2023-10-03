namespace SEDC.PizzaApp.Models
{
    public class PizzaViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public PizzaSize PizzaSize { get; set; }

        public bool HasExtras { get; set; }

        public bool IsOnPromotion { get; set; }
    }
}
