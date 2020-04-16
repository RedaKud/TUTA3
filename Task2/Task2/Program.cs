using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Write second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            int sum = firstNum + secondNum;

            Console.WriteLine("Results: {0}", sum);
        }
    }
}
