namespace GitHubCopilotTesting;

class Program
{
    static void Main()
    {
        int[] array = [34, 7, 23, 32, 5, 62];

        QuickSortSample(array);
        InsertionSortSample(array);
        BubbleSortSample(array);
    }

    private static void QuickSortSample(int[] arrayQuick)
    {
        Console.WriteLine($"Original array: {string.Join(", ", arrayQuick)}");

        QuickSort.Sort(arrayQuick);

        Console.WriteLine($"Sorted array: {string.Join(", ", arrayQuick)}");
    }

    private static void InsertionSortSample(int[] arrayInsertion)
    {
        Console.WriteLine($"Original array: {string.Join(", ", arrayInsertion)}");

        InsertionSort.Sort(arrayInsertion);

        Console.WriteLine($"Sorted array: {string.Join(", ", arrayInsertion)}");
    }

    private static void BubbleSortSample(int[] arrayBubble)
    {
        Console.WriteLine($"Original array: {string.Join(", ", arrayBubble)}");

        BubbleSort.Sort(arrayBubble);

        Console.WriteLine($"Sorted array: {string.Join(", ", arrayBubble)}");
    }
}
