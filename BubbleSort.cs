using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class Bubble
    {
        
        public static void bubbleSort(int[] arr)
        {
            
            int num=arr.Length;
            for (int i = 0; i < num - 1; i++)
            {
                for (int j = 0; j < num - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                   
            }
                
        }
        public static void printIt(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
               Console.Write(arr[i] + " ");
            }
                
            Console.WriteLine();
        }
    }
    
}
