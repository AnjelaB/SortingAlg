using System;

namespace SortName
{
    /// <summary>
    /// Class for Merge Sort Algorithm .
    /// </summary>
    public class Merge
    {
        /// <summary>
        /// The Array for merge sorting.
        /// </summary>
        private int[] array;

        /// <summary>
        /// Field to count the Memory using in sort method.
        /// </summary>
        private static int memory = 0;

        /// <summary>
        /// Parameterized constructor with array type parameter.
        /// </summary>
        /// <param name="arr">Parameter to initialize field.</param>
        public Merge(int[] arr)
        {
            array = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[i];
            }

        }

        /// <summary>
        /// Parameterless canstructor.
        /// </summary>
        public Merge()
        {
            array = new int[0];
        }

        /// <summary>
        /// Method to sort field with merge algorithm.
        /// </summary>
        public void Sort()
        {
            array=MergeSort(array);
        }

        /// <summary>
        /// Method to sort an array with int[] type using merge sorting algorithm.
        /// </summary>
        /// <param name="arr">Array that must be sorted.</param>
        /// <returns></returns>
        private int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
                return arr;
            int[] arr1 = new int[arr.Length / 2];
            int[] arr2;
            if (arr.Length % 2 == 0)
                arr2 = new int[arr.Length / 2];
            else
                arr2 = new int[(arr.Length / 2) + 1];
            memory += (arr1.Length + arr2.Length)*4;
            for(int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[i];
            }
            for (int i =0,j=arr.Length/2; i < arr2.Length; i++,j++)
            {
                arr2[i] = arr[j];
            }
            arr1=MergeSort(arr1);
            arr2=MergeSort(arr2);
            arr = Help(arr1, arr2);
            return arr;
        }

        /// <summary>
        /// Method to merge and sort two arrays. 
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        private int[] Help(int[] arr1,int[] arr2)
        {
            var arr = new int[arr1.Length + arr2.Length];
            int index1 = 0;
            int index2 = 0;
            int index3 = 0;
            while (index1 < arr.Length)
            {
                if (index2 < arr1.Length && index3 < arr2.Length)
                {
                    if (arr1[index2] <= arr2[index3])
                    {
                        arr[index1] = arr1[index2];
                        index2++;
                    }
                    else
                    {
                        arr[index1] = arr2[index3];
                        index3++;
                    }
                    index1++;
                }
                else if (index2 < arr1.Length)
                {
                    arr[index1] = arr1[index2];
                    index1++;
                    index2++;
                }
                else if (index3 < arr2.Length)
                {
                    arr[index1] = arr2[index3];
                    index1++;
                    index3++;
                }
            }
            return arr;
        }

        /// <summary>
        /// Method to print array.
        /// </summary>
        public void Print(bool t)
        {
            if (t)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (int el in array)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine("Merge Sort Memory:" + memory);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                
                foreach (int el in array)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine("Merge Sort Memory:" + memory);
                
            }
        }
    }
}
