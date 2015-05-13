using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceOneHundredNaturalNumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numA = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                numA.Add(i*i);
            }
          
            int sumOfSq = numA.Sum();
            

            List<int> numB = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                numB.Add(i);
            }
            int sqSum = (numB.Sum()) * (numB.Sum());
            

            Console.WriteLine(sqSum-sumOfSq);
            Console.ReadKey();
        }
    }
}
