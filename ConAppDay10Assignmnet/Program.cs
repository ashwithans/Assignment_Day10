using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay10Assignmnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nOriginal Array:");
            PrintArray(arr);

            BubbleSort.Sort(arr); 
            Console.WriteLine("\nSorted Array (Descending Order):");
            PrintArray(arr);

        

            Console.Write("\nEnter a value to search in the sorted array: ");
            int searchValue = Convert.ToInt32(Console.ReadLine());
            int result = BinarySearch.Search(arr, searchValue); 
            if (result != -1)
            {
                Console.WriteLine($"\n{searchValue} found at index {result}.");
            }
            else
            {
                Console.WriteLine($"\n{searchValue} not found in the array.");
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}