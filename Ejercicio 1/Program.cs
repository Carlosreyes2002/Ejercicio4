using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 20;

            if (num1 > num2)
            {
                Console.WriteLine("{0} es mayor que {1}", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} es menor o igual que {1}", num1, num2);
            }
        }
    }
}
