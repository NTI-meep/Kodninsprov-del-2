using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband_test
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int choiceNr = 0; // Andänds för konversion senare i koden 

            Console.WriteLine("Hur många bilar vill du att ska skapas?");// Instruktioner till spelaren 
            string choice = Console.ReadLine();

            Int32.TryParse(choice, out choiceNr); // Tar strin informationen och konverterar den till in 

            while(choiceNr < 1) // Om spelaren skrev mindre än noll så går det inte att gå vidare 
            {
                Console.WriteLine("You have to make atleast one car");

            }

            List<Car> cars = new List<Car>(); // En lista där spelaren ska kunna lägga till antal av klassen car 
            {
                int i = 0;
                while ( i == 0)
                {
                    Car newCars = new Car();
                    cars.Add(newCars); // Lägger till ny bil 


                }



            }

            Console.ReadLine(); // Läser in 
        }
    }
}
