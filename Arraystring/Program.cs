using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraystring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            string[] names = { "aachal", "kajal", "rechal", "pranjal" };
            Console.WriteLine("enter 5 elements");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----------------");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"names {i}={names[i]}");
            }
        }
    }
}
