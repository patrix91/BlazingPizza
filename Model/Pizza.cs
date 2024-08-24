using BlazingPizza.Model;

namespace BlazingPizza
{
    /// <summary>
    /// Przedstawia customową pizze, którą można zamówić.
    /// </summary>
    public class Pizza
    {
        public const int DefaultSize = 32;
        public const int MinimumSize = 28;
        public const int MaximumSize = 50;

        public static int[] AllowedValues { get; set; } = { 28, 32, 42, 50 };

        public int Id { get; set; }

        public int OrderId { get; set; }

        public PizzaSpecial Special { get; set; }

        public int SpecialId { get; set; }

        public int Size { get; set; }

        /// <summary>
        /// Topy - czyli składniki dodatkowe, które można dodać do pizzy.
        /// </summary>
        public List<PizzaTopping> Toppings { get; set; }

        public decimal GetBasePrice()
        {
            return ((decimal)Size / (decimal)DefaultSize) * Special.BasePrice;
        }

        public decimal GetTotalPrice()
        {
            return GetBasePrice();
        }

        public string GetFormattedTotalPrice()
        {
            return GetTotalPrice().ToString("0.00");
        }
    }
}
