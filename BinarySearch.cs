using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BinarySearch
    {
        public static void SearchFromList()
        {
            List<string> colours = new List<string>();
            colours.Add("Blue");
            colours.Add("Green");
            colours.Add("Black");
            colours.Add("Red");
            colours.Add("Yellow");
            Console.WriteLine("Initial list:");
            Console.WriteLine();
            foreach(string colour in colours)
            {
                Console.WriteLine(colour);
                
            }
            Console.WriteLine("\nSort:");
            colours.Sort();
            Console.WriteLine();
            foreach (string colour in colours)
            {
                Console.WriteLine(colour);

            }
            Console.WriteLine("\nBinary search");
            Console.Write("Enter the word to be searched: ");
            string word = Console.ReadLine();
            int index = colours.BinarySearch(word);
            if(index > 0)
            {
                Console.WriteLine("word found");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
