namespace GitHubCopilotTesting;

class Program
{
    static void Main()
    {
        int[] array = [ 34, 7, 23, 32, 5, 62 ];
        Console.WriteLine("Original array: " + string.Join(", ", array));

        QuickSort.Sort(array);

        Console.WriteLine("Sorted array: " + string.Join(", ", array));
    }
}

