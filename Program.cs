using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Debug_Buoi1
{
    class Program
    {
        //MergeSort
        public static void mergeSort(int[] arr)
        {

            if (arr.Length <= 1)
                return;

            int mid = arr.Length / 2;

            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];

            for (int i = 0; i < mid; i++)
                left[i] = arr[i];

            for (int i = mid; i < arr.Length; i++)
                right[i - mid] = arr[i];

            mergeSort(left);
            mergeSort(right);

            Merge(arr, left, right);
        }

        private static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    arr[k++] = left[i++];
                else
                    arr[k++] = right[j++];
            }

            while (i < left.Length)
                arr[k++] = left[i++];

            while (j < right.Length)
                arr[k++] = right[j++];
        }

        // QuickSort


        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                Sort(arr, left, pivot - 1);
                Sort(arr, pivot + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp1;

            return i + 1;
        }
        static void Main(string[] args)
        {
            Console.Title = "Selection Sort";
            var numbers = new[] { 10, 3, 1, 7, 9, 2, 0 };
            Console.Write("Mang:");
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write(" " + numbers[i]);
            }

            Console.Write("\nMang giam dan:");
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int m = i;
                int maxValue = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j].CompareTo(maxValue) > 0)
                    {
                        m = j;
                        maxValue = numbers[j];
                    }
                }
                int temp = numbers[i];
                numbers[i] = numbers[m];
                numbers[m] = temp;

                Console.Write(" " + numbers[i]);
            }

            Console.Write("\nMang tang dan:");
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int m = i;
                int minValue = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j].CompareTo(minValue) < 0)
                    {
                        m = j;
                        minValue = numbers[j];
                    }
                }

                int temp = numbers[i];
                numbers[i] = numbers[m];
                numbers[m] = temp;

                Console.Write(" " + numbers[i]);
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                sum += numbers[i];

            }
            Console.Write("\nTong mang = " + sum);

            Console.Write("\nMerge Sort");

            int[] ints = { 8, 875, 7, 9, 764, 55 };

            Console.Write("\nOriginal array: ");
            foreach (int i in ints)
            {
                Console.Write(" " + i);
            }

            //MergeSortMain
            mergeSort(ints);

            Console.Write("\nSorted array: ");

            foreach (int i in ints)
            {
                Console.Write(" " + i);
            }

            Console.Write("\nQuick Sort");
            int[] intss = { 8, 875, 7, 9, 764, 55 };

            Console.Write("\nOriginal array:");
            foreach (int i in intss)
            {
                Console.Write(" " + i);
            }


            Sort(intss, 0, 5);

            Console.Write("\nSorted array:");

            foreach (int i in intss)
            {
                Console.Write(" " + i);
            }

            Console.ReadKey();

        }
    }
}