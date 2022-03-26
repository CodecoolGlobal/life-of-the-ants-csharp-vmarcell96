using System;
using Codecool.LifeOfAnts.Ants;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codecool.LifeOfAnts.Ants;

namespace Codecool.LifeOfAnts
{
    /// <summary>
    ///     Simulation main class
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///     Main method
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Hello, Ants!");
            var colony = new Colony(15);
            colony.GenerateAnts(2, 2, 2);
            colony.Display();
            string input = "";
            while (input != "q")
            {
                input = Console.ReadLine();
                if (input == "")
                {
                    Console.Clear();
                    Console.WriteLine("User pressed \"Enter\"");
                    colony.Update();
                    colony.Display();
                }
            }
            Console.WriteLine("See you next time!");
        }
    }
}
