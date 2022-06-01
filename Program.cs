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
                Console.WriteLine("\n1: Program for returning all the permutations of a string");
                Console.WriteLine("6: Program for checking whether 2 strings are Anagram or not");
                Console.WriteLine("7: Take a range of 0 - 1000 Numbers and find the Prime numbers in that range");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string str = "ABCD";
                        int strlength = str.Length;
                        PermutationsOfGivenString.Permute(str, 0, strlength - 1);
                        break;
                     case 6:
                        string firststring,secondstring;
                        Console.WriteLine("Enter first string");
                        firststring = Console.ReadLine();
                        Console.WriteLine("Enter second string");
                        secondstring = Console.ReadLine();
                        //check words are anagram or not
                        if(Anagram.CheckAnagram(firststring,secondstring) == true)
                        {
                            Console.WriteLine("The words are Anagram!!");
                        }
                        else
                        {
                            Console.WriteLine("Words are not Anagram!!");
                        }
                        break;
                     case 7:
                        PrimeNumber.PrimeNumbersInRange();
                        break;
                }
            }
            while (true);
        }
    }
}
