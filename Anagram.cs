using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class Anagram
    {
        public static bool CheckAnagram(string firststring, string secondstring)
        {
            if (firststring.Length != secondstring.Length)
            {
                return false;
            }
            //Convert string into character array
            char[] FirstCharArray = firststring.ToLower().ToCharArray();
            char[] SecondCharArray = secondstring.ToLower().ToCharArray();
            //Sort array
            Array.Sort(FirstCharArray);
            Array.Sort(SecondCharArray);
            //check each chara and position
            for (int i = 0; i < FirstCharArray.Length; i++)
            {
                if (FirstCharArray[i].ToString() != SecondCharArray[i].ToString())
                {
                    return false;
                }
            }
            return true;
        }      
    }
}
