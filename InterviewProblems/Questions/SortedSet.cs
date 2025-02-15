using System;
using System.Collections.Generic;
using Xunit;

namespace InterviewProblems.Questions
{
    public class SortedSetTest
    {
        [Fact]
        public void TestSortedSet_AddElements()
        {
            // Arrange
            SortedSet<int> sortedSet = new SortedSet<int>();

            // Act
            sortedSet.Add(5);
            sortedSet.Add(1);
            sortedSet.Add(3);

            // Assert
            Assert.Equal(3, sortedSet.Count);
            Assert.Contains(1, sortedSet);
            Assert.Contains(3, sortedSet);
            Assert.Contains(5, sortedSet);
        }

        [Fact]
        public void TestSortedSet_DuplicateElements()
        {
            // Arrange
            SortedSet<int> sortedSet = new SortedSet<int>();

            // Act
            sortedSet.Add(5);
            sortedSet.Add(5);

            // Assert
            Assert.Equal(1, sortedSet.Count);
        }

        [Fact]
        public void TestSortedSet_Order()
        {
            // Arrange
            SortedSet<int> sortedSet = new SortedSet<int>();

            // Act
            sortedSet.Add(5);
            sortedSet.Add(1);
            sortedSet.Add(3);

            // Assert
            int[] expectedOrder = [1, 3, 5];
            Assert.Equal(expectedOrder, sortedSet.ToArray());
        }

        [Fact]
        public void TestSortedSet_RemoveElement()
        {
            // Arrange
            SortedSet<int> sortedSet = new SortedSet<int> { 1, 3, 5 };

            // Act
            sortedSet.Remove(3);

            // Assert
            Assert.Equal(2, sortedSet.Count);
            Assert.DoesNotContain(3, sortedSet);
        }
    }
}