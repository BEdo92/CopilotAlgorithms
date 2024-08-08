using NUnit.Framework;

namespace GitHubCopilotTesting.Tests
{
    public class QuickSortTests
    {
        [Test]
        public void Sort_ShouldSortArrayInAscendingOrder()
        {
            // Arrange
            int[] array = { 5, 2, 8, 3, 1, 9, 4, 7, 6 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act
            QuickSort.Sort(array);

            // Assert
            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Sort_ShouldSortArrayWithDuplicateValues()
        {
            // Arrange
            int[] array = { 5, 2, 8, 3, 1, 9, 4, 7, 6, 5 };
            int[] expected = { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9 };

            // Act
            QuickSort.Sort(array);

            // Assert
            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Sort_ShouldSortArrayWithNegativeValues()
        {
            // Arrange
            int[] array = { -5, 2, -8, 3, -1, 9, -4, 7, -6 };
            int[] expected = { -8, -6, -5, -4, -1, 2, 3, 7, 9 };

            // Act
            QuickSort.Sort(array);

            // Assert
            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Sort_ShouldSortEmptyArray()
        {
            // Arrange
            int[] array = new int[0];
            int[] expected = new int[0];

            // Act
            QuickSort.Sort(array);

            // Assert
            Assert.AreEqual(expected, array);
        }
    }
}
