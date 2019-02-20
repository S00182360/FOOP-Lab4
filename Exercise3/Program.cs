using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercises 3 & 4 are contained in this project.
            Car c1 = new Car("SlugBug", 100, 10);

            c1.AboutToBlow += OnCarEngineEvent;
            c1.Exploded += OnCarEngineEvent;


            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.ReadKey();

        }

        static void OnCarEngineEvent(object sender, CarEventArgs e)
        {
            Console.WriteLine("Message from Car Object\n");
            Console.WriteLine(e.message);
            Console.WriteLine("**********************************");
        }

        static void OnCarEngineEvent2(object sender, CarEventArgs e)
        {
            Console.WriteLine(e.message.ToUpper());
        }
    }
}
