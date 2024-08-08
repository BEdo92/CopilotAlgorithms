﻿namespace GitHubCopilotTesting;

public class QuickSort
{
    /// <summary>
    /// Sorts the array using the quick sort algorithm.
    /// </summary>
    /// <param name="array">The array to sort.</param>
    public static void Sort(int[] array)
    {
        QuickSortArray(array, 0, array.Length - 1);
    }

    private static void QuickSortArray(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);
            QuickSortArray(array, low, pivotIndex - 1);
            QuickSortArray(array, pivotIndex + 1, high);
        }
    }

    private static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);
        return i + 1;
    }

    private static void Swap(int[] array, int a, int b)
    {
        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }
}

