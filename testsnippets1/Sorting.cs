using System;
using System.Collections.Generic;
using System.Text;

namespace testsnippets1
{
    internal class Sorting
    {
        public static void BubbleSort(List<int> numbers)
        {
            int n = numbers.Count;
            Console.WriteLine("Bubble Sort:");
            Console.WriteLine("for:");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Swap numbers[j] and numbers[j + 1]
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                    numberlist(numbers);
                }
                
                
            }
            Console.WriteLine("foreach:");
            //bubble sort in foreach
            foreach (var item in numbers.ToList()) // use ToList() to avoid modifying during iteration
            {
                foreach (var item1 in numbers.ToList())
                {
                    if (item < item1)
                    {
                        int indexItem = numbers.IndexOf(item);
                        int indexItem1 = numbers.IndexOf(item1);

                        // Swap
                        int temp = numbers[indexItem];
                        numbers[indexItem] = numbers[indexItem1];
                        numbers[indexItem1] = temp;
                    }
                }
                numberlist(numbers);
            }

            
        }
        public static void SelectionSort(List<int> numbers)
        {
            int n = numbers.Count;
            Console.WriteLine("Selection Sort:");
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Swap numbers[i] and numbers[minIndex]
                int temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
                numberlist(numbers);
            }
        }
        public static void InsertionSort(List<int> numbers)
        {
            int n = numbers.Count;
            Console.WriteLine("Insertion Sort:");
            for (int i = 1; i < n; i++)
            {
                int key = numbers[i];
                int j = i - 1;
                // Move elements of numbers[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
                numberlist(numbers);
            }
        }
        public static void MergeSortCall(List<int> numbers)
        {
            Console.WriteLine("Merge Sort:");
            MergeSort(numbers);
        }
        public static void MergeSort(List<int> numbers)
        {
            if (numbers.Count <= 1)
                return;
            int mid = numbers.Count / 2;
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            for (int i = 0; i < mid; i++)
                left.Add(numbers[i]);
            for (int i = mid; i < numbers.Count; i++)
                right.Add(numbers[i]);
            MergeSort(left);
            MergeSort(right);
            int leftIndex = 0, rightIndex = 0, mainIndex = 0;
            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    numbers[mainIndex++] = left[leftIndex++];
                }
                else
                {
                    numbers[mainIndex++] = right[rightIndex++];
                }
            }
            while (leftIndex < left.Count)
                numbers[mainIndex++] = left[leftIndex++];
            while (rightIndex < right.Count)
                numbers[mainIndex++] = right[rightIndex++];
           numberlist(numbers);
        }
        public static void numberlist(List<int> numbers)
        {

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
