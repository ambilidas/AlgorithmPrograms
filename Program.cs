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
                Console.WriteLine("2: Binary search a word from Word list");
                Console.WriteLine("3: Insertion Sort");
                Console.WriteLine("4: Bubble Sort");
                Console.WriteLine("6: Program for checking whether 2 strings are Anagram or not");
                Console.WriteLine("7: Take a range of 0 - 1000 Numbers and find the Prime numbers in that range");
                Console.WriteLine("8: Extend the above program to find the prime numbers that are Anagram and Palindrome");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                     case 1:
                        string str = "ABCD";
                        int strlength = str.Length;
                        PermutationsOfGivenString.Permute(str, 0, strlength - 1);
                        break;
                     case 2:
                        break;
                     case 3:
                        string[] colors = { "blue", "green", "yellow", "orange" };
                        InsertionSort.InsertSort(colors);
                        foreach(var item in colors)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                     case 4:
                        int[] arr = { 50, 20, 70, 60, 30, 40 };
                        Bubble.bubbleSort(arr);
                        Console.WriteLine("Sorted array\n");
                        Bubble.printIt(arr);
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
                    case 8:
                        PrimeNumberWhichIsAnagramandPalindrome.PrimeNumbers();
                        break;
                }
            }
            while (true);
        }
    }
}
