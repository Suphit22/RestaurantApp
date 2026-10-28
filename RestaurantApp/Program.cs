using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suphitsara");
            Console.WriteLine("Phichanin");

            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7)
            };

        }

    }
    public class Restaurant
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public double Rate { get; set; }

        public Restaurant(int ID, string Name, string Type, double Rate)
        {

        }
    }
}
