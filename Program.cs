using System;

namespace AlgorithmPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tWELCOME TO ALGORITHM PROGRAMS");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("Enter the question number for executing the program");
            

            do
            {
                Console.WriteLine("1: Program for returning all the permutations of a string");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string str = "ABC";
                        int strlength = str.Length;
                        PermutationsOfGivenString.Permute(str, 0, strlength - 1);
                        break;
                }
            }
            while (true);
        }
    }
}
