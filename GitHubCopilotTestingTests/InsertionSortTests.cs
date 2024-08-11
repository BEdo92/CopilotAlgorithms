using GitHubCopilotTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubCopilotTestingTests;

[TestFixture]
public class InsertionSortTests
{
    [Test]
    public void Sort_ShouldSortArrayInAscendingOrder()
    {
        // Arrange
        int[] array = [5, 2, 8, 3, 1, 9, 4, 7, 6];
        int[] expected = [1, 2, 3, 4, 5, 6, 7, 8, 9];

        // Act
        InsertionSort.Sort(array);

        // Assert
        Assert.That(array, Is.EqualTo(expected));
    }

    [Test]
    public void Sort_ShouldSortArrayWithDuplicateValues()
    {
        // Arrange
        int[] array = [5, 2, 8, 8, 8, 13, 13, 3, 1, 9, 4, 7, 6, 5];
        int[] expected = [1, 2, 3, 4, 5, 5, 6, 7, 8, 8, 8, 9, 13, 13];

        // Act
        InsertionSort.Sort(array);

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
        InsertionSort.Sort(array);

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
        InsertionSort.Sort(array);

        // Assert
        Assert.That(array, Is.EqualTo(expected));
    }

    [Test]
    public void Sort_ShouldSortArrayWithHugeNumbers()
    {
        // Arrange
        int[] array = [int.MaxValue, int.MinValue, int.MaxValue - 1, int.MinValue + 1];
        int[] expected = [int.MinValue, int.MinValue + 1, int.MaxValue - 1, int.MaxValue];

        // Act
        InsertionSort.Sort(array);

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
        InsertionSort.Sort(array);

        // Assert
        Assert.That(array, Is.EqualTo(expected));
    }

    [Test]
    public void Sort_ShouldSortArrayWithTwoElements()
    {
        // Arrange
        int[] array = [5, 2];
        int[] expected = [2, 5];

        // Act
        InsertionSort.Sort(array);

        // Assert
        Assert.That(array, Is.EqualTo(expected));
    }

    [Test]
    public void Sort_ShouldSortVeryLargeArrays()
    {
        // Arrange
        int lengthOfArray = 20_000;

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
