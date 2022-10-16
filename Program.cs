/*
Implement 3 sort algorithms:
Selection
Bubble
Insertion
Extra:
Define enum SortAlgorithmType with all 3 algorithms types and create single function Sort that will accept array and SortAlgorithmType and use passed algorithm to sort array
Define enum OrderBy with 2 values: Asc and Desc and update Sort method with this parameter that will change sort order
*/

using System.Drawing;

namespace hw5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int SIZE = 5;
            int[] arr = new int[SIZE] { -9, 69, 32, 8, 46 };

            Console.WriteLine("Unsorted array:");
            PrintArray(arr, SIZE);

            SelectionSort(arr, SIZE);
            Console.WriteLine("Sorted array by selection sort: ");
            PrintArray(arr,SIZE);

            BubbleSort(arr, SIZE);
            Console.WriteLine("Sorted array by bubble sort: ");
            PrintArray(arr, SIZE);

            InsertionSort(arr, SIZE);
            Console.WriteLine("Sorted array by insertion sort: ");
            PrintArray(arr, SIZE);

            //sort(SortAlgorithmType.BubbleSort, arr, SIZE);
        }

        //selection sort
        static int[] SelectionSort(int[] arr, int SIZE)
        {
            for (int i = 0; i < SIZE; i++)
            {
                int MinValue = i;
                for (int j = i + 1; j < SIZE; j++)
                    if (arr[j] < arr[MinValue])
                        Swap(ref arr[i], ref arr[j]);
            }
            return arr;
        }

        //bubble sort
        static int[] BubbleSort(int[] arr, int SIZE)
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = i + 1; j < SIZE; j++)
                    if (arr[i] > arr[j])
                        Swap(ref arr[i], ref arr[j]);
            }
            return arr;
        }

        //insertion sort
        static int[] InsertionSort(int[] array, int SIZE)
        {
            for (int i = 1; i < SIZE; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
                array[j] = key;

            }

            return array;
        }

        static void Swap(ref int a, ref int b)
        {
            var flag = a;
            a = b;
            b = flag;
        }

        static void PrintArray(int[] arr, int SIZE)
        {
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }

        /*
        void sort(SortAlgorithmType algorithmType, int[] arr, int SIZE)
        {
            string sortType = "";
            switch (algorithmType)
            {
                case SortAlgorithmType.SelectionSort:
                    SelectionSort(arr, SIZE);
                    sortType = "Selection Sort";
                    break;
                case SortAlgorithmType.BubbleSort:
                    BubbleSort(arr, SIZE);
                    sortType = "Bubble Sort";
                    break;
                case SortAlgorithmType.InsertionSort:
                    InsertionSort(arr, SIZE);
                    sortType = "Insertion Sort";
                    break;
            }
        }
        */
        public enum SortAlgorithmType
        {
            SelectionSort,
            BubbleSort,
            InsertionSort
        }
    }
}
