using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_Herança_e_Polimorfismo.Entities;

namespace Exercicio_Herança_e_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Product #1 Data:");
                Console.WriteLine("Common(1), used(2) or imported(3)");
                Console.Write("Answer: ");
                int typeOfProduct = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if(typeOfProduct == 1)
                {
                    list.Add(new Product(name, price));
                }
                else if (typeOfProduct == 2)
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, date));
                }
                else if (typeOfProduct == 3)
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                   list.Add(new ImportedProduct(name, price, customsFee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Price Tags:");
            foreach (Product x in list)
            {
                Console.WriteLine(x.PriceTag());
            }
            Console.ReadLine();
        }
    }
}
