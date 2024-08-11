using GitHubCopilotTesting;
using NUnit.Framework;

namespace GitHubCopilotTestingTests;

[TestFixture]
public class BubbleSortTests
{
    [Test]
    public void Sort_ShouldSortArrayInAscendingOrder()
    {
        // Arrange
        int[] array = [5, 2, 8, 3, 1, 9, 4, 7, 6];
        int[] expected = [1, 2, 3, 4, 5, 6, 7, 8, 9];

        // Act
        BubbleSort.Sort(array);

        // Assert
        //Assert.Equals(expected, array);
        Assert.That(array, Is.EqualTo(expected));
    }

    [Test]
    public void Sort_ShouldSortArrayWithDuplicateValues()
    {
        // Arrange
        int[] array = [5, 2, 8, 8, 8, 13, 13, 3, 1, 9, 4, 7, 6, 5];
        int[] expected = [1, 2, 3, 4, 5, 5, 6, 7, 8, 8, 8, 9, 13, 13];

        // Act
        BubbleSort.Sort(array);

        // Assert
        Assert.That(array, Is.EqualTo(expected));
    }

    [Test]
    public void Sort_ShouldSortArrayWithNegativeValues()
    {
        // Arrange
        int[] array = [-5, 2, -8, 3, -1, 9, -4, 7, -6];
        int[] expected = [-8, -6, -5, -4, -1, 2, 3, 7, 9];

        // Act
        BubbleSort.Sort(array);

        // Assert
        Assert.That(array, Is.EqualTo(expected));
    }

    [Test]
    public void Sort_ShouldSortEmptyArray()
    {
        // Arrange
        int[] array = [];
        int[] expected = [];

        // Act
        BubbleSort.Sort(array);

        // Assert
        Assert.That(array, Is.EqualTo(expected));
    }

    [Test]
    public void Sort_ShouldSortArrayWithOneElement()
    {
        // Arrange
        int[] array = [5];
        int[] expected = [5];

        // Act
        BubbleSort.Sort(array);

        // Assert
        Assert.That(array, Is.EqualTo(expected));
    }

    [Test]
    public void Sort_ShouldSortArrayWithHugeNumbers()
    {
        // Arrange
        int[] array = [100_000_000, 1_000_000_000, 10_000_000, 1_000_000];
        int[] expected = [1_000_000, 10_000_000, 100_000_000, 1_000_000_000];

        // Act
        QuickSort.Sort(array);

        // Assert
        Assert.That(array, Is.EqualTo(expected));
    }

    [Test]
    public void Sort_ShouldSortVeryLargeArrays()
    {
        // Arrange
        int lengthOfArray = 10_000;

        int[] array = new int[lengthOfArray];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array.Length - i;
        }

        int[] expected = new int[lengthOfArray];
        for (int i = 0; i < expected.Length; i++)
        {
            expected[i] = i + 1;
        }

        // Act
        QuickSort.Sort(array);

        // Assert
        Assert.That(array, Is.EqualTo(expected));
    }
}
