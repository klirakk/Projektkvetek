using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Projektkveten
{
    private class Product
    {

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }

    private static class Inventory
    {
        public static List<Product> Products { get; set; } = new List<Product>();

        public static int NumberOfProducts { get; set; }

        public static void AddProduct(string name, double price)
        {
            Products.Add(new Product(name, price));

            Console.Clear();
            Console.WriteLine("Produkt byl přidán");
            Console.ReadKey();
        }

    }
    public static void Main()
    {

        while (true) {
            Console.Clear();
            Console.WriteLine("Zadej proces (pridat, odebrat, zobrazit, konec)");
            string inputA = Console.ReadLine();

            if (inputA == "pridat")
            {
                Console.Clear();
                Console.WriteLine("Napiš nazev produktu");
                string name = Console.ReadLine();
                Console.WriteLine("Napiš cenu produktu");
                double cena = double.Parse(Console.ReadLine());

                Inventory.AddProduct(name, cena);
            }
            else if (inputA == "odebrat")
            {
                Console.Clear();
                Console.WriteLine(inputA);
                Console.WriteLine("který z těchto produktů chceš odebrat?");
            }
            else if (inputA == "zobrazit")
            {
                Console.Clear();
                foreach (var product in Inventory.Products) Console.WriteLine($"Jméno: {product.Name}, Cena: {product.Price}");
                Console.ReadKey();


            }
            else if (inputA == "konec") break;
        }
        
    }
}
