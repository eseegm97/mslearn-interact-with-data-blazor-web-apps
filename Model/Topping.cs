using System.Globalization;

namespace BlazingPizza
{
    public class Topping
    {
        private static readonly CultureInfo UsCulture = CultureInfo.GetCultureInfo("en-US");
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string GetFormattedPrice() => Price.ToString("C", UsCulture);
    }
}
