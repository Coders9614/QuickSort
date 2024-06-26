using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSortExample
    {
        // Method to perform Quick Sort
        public static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSort(array, low, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, high);
            }
        }

        // Partition method to rearrange the array
        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);
            return i + 1;
        }

        // Utility method to swap two elements in an array
        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        // Utility method to print the array
        public static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        // Main method
        static void Main(string[] args)
        {
            int[] array = { 1,33,77, 5, 20, 12 };
            Console.WriteLine("Unsorted array:");
            PrintArray(array);

            QuickSort(array, 0, array.Length - 1);

            Console.WriteLine("Sorted array:");
            PrintArray(array);
            Console.ReadKey();
        }
    }
}
