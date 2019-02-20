using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinaryOp del1 = new BinaryOp(SimpleMaths.Add);
            //BinaryOp del2 = new BinaryOp(SimpleMaths.Subtract);

            //del1 += del2;

            //DoWork(del1);

            Car c1 = new Car("SlugBug", 100, 10);

            c1.listOfHandlers += new CarEngineHandler(OnCarEngineEvent);
            c1.listOfHandlers += OnCarEngineEvent2;

            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            Console.ReadKey();

        }

        static void DoWork(BinaryOp del)
        {
            del(20, 10);
        }

        static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("Message from Car Object\n");
            Console.WriteLine(msg);
            Console.WriteLine("**********************************");
        }

        static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine(msg.ToUpper());
        }

    }

    public delegate void BinaryOp(int x, int y);

    public class SimpleMaths
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("The sum of {0} and {1} is {2}", x, y, (x + y));
        }

        public static void Subtract(int x, int y)
        {
            Console.WriteLine("The difference of {0} and {1} is {2}", x, y, (x - y));
        }

    }
}


