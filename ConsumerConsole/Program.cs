using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassDemoRestConsumer;
using ModelLib.model;

namespace ConsumerConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            

            while (true)
            {
                Console.Clear();
                Console.WriteLine("FACILITETER");
                Console.WriteLine("\n1: VIS ALLE");
                Console.WriteLine("2: OPRET NY");
                ConsoleKey menu = Console.ReadKey().Key;

                MainMenu(menu);
            }

        }

        private static void MainMenu(ConsoleKey menu)
        {
            switch (menu)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("Alle Faciliteter\n");
                    Worker worker = new Worker();
                    worker.Start();
                    Console.ReadKey();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("OPRET NY\n");
                    Console.WriteLine("Id: |  Name: ");

                    Console.Write(" ID: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Navn: ");
                    string y = Console.ReadLine();
                    Console.Write($"ID: {x}, Name: {y}");

                    Facility f = new Facility(){Id=x, Name =y};

                    Worker w = new Worker();
                    w.Post(f);
                    Console.ReadKey();
                    break; 
            }
        }
    }
}
