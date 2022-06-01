using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PermutationsOfGivenString
    {
        public static void Permute(string str,int startIndex,int endIndex)
        {
            if (startIndex == endIndex)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    str = Swap(str, startIndex, i);
                    Permute(str, startIndex + 1, endIndex);
                    str = Swap(str, startIndex, i);
                }
            }
        }
        public static string Swap(string a,int i,int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
