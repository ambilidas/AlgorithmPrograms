using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimeNumber
    {
        public static void PrimeNumbersInRange()
        {
            int num;
            int startNum = 0;
            int endNum = 1000; int sum=0;int c;
            Console.WriteLine("The Prime Numbers between 0 and 1000 are:\n");
            for (num = startNum; num <= endNum; num++)
            {
                bool test = false;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        test = true;
                        break;
                    }
                }

                if (test == false)
                    Console.Write("{0} ", num);
            }
              Console.WriteLine("\n");

           

        }
           
        
    }
}
