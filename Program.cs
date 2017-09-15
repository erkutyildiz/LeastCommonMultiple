using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestNumberDividedBy1To20
{
//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (true)
            {
                    if (Ekok(i))
                        break;
                    else
                        i++;
            }

            Console.WriteLine("Smallest number is : {0} divided by each number between 1 and 20", i);
            Console.ReadLine();
            
            bool Ekok(int z)
            {
                for (int x = 1; x <= 20; x++)
                {
                    if (z % x != 0)
                        return false;
                }
                return true;
            }
        }
    }
}
