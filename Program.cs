
/*
Author: Mohan Ananta Venkata Pavan Gamidi
Date: 2/28/2024
Comments: This C# Console Application code demonstrates the Bubble Sort Algorithms.
*/


class BubbleSort
{
    static void Main(string[] args)
    {
        int[] array = { 3, 62, 5, 16, 4, 10};
        Console.WriteLine("Original array:");
        PrintArray(array);

        BubbleSortAlgorithm(array);

        Console.WriteLine("\nSorted array:");
        PrintArray(array);
    }
    static void BubbleSortAlgorithm(int[] array)
    {
        int n = array.Length;
        bool swapped;
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap array[j] and array[j + 1]
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no swapping occurred, the array is already sorted
            if (!swapped)
                break;
        }
    }
   static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
