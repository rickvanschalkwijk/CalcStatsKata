using System.Collections.Generic;

using NUnit.Framework;

namespace CalcStatsKata
{
    [TestFixture]
    public class CalcStatsKataTests
    {
        private CalcStats calcStats;

        [SetUp]
        public void SetUp()
        {
            calcStats = new CalcStats();                
        }

        [Test]
        public void FindMin_ShouldFindMinimalNumberInList_ReturnMinimalNumberInList()
        {
            // Arrange

            // Act
            int actual = calcStats.FindMin(new List<int> { 6, 9, 15, 92, 11 });

            // Assert
            Assert.That(actual, Is.EqualTo(6));   
        }

        [Test]
        public void FindMin_ShouldFindMinimalNumberInListWhenListContainsNegativeValue_ReturnMinimalNumberInList()
        {
            // Arrange

            // Act
            int actual = calcStats.FindMin(new List<int> { 6, 9, 15, -2, 92, 11 });
          
            // Assert
            Assert.That(actual, Is.EqualTo(-2));
        }

        [Test]
        public void FindMax_ShouldFindMaxWhenMaxIs99_ReturnMax()
        {
            // Arrange

            // Act
            int actual = calcStats.FindMax(new List<int> { 6, 9, 15, -2, 92, 99 });

            // Assert
            Assert.That(actual, Is.EqualTo(99));  
        }

        [Test]
        public void FindMax_ShouldFindMaximalNumberInList_ReturnMaximalNumberInList()
        {
            // Arrange

            // Act
            int actual = calcStats.FindMax(new List<int> { 6, 9, 15, -2, 92, 11 });
            
            // Assert
            Assert.That(actual, Is.EqualTo(92));
        }

        [Test]
        public void GetLength_ShouldReturnNumberOfItemsInListAsInt_ReturnLength()
        {
            // Arrange

            // Act
            int actual = calcStats.GetLength(new List<int> { 1, 2, 3 });

            // Assert
            Assert.That(actual, Is.EqualTo(3));
        }

        [Test]
        public void GetAverage_ShouldCalculateTheAverageOfAllTheNumbersInTheList_ReturnAverage()
        {
            // Arrange

            // Act
            int actual = calcStats.GetAverage(new List<int> { 6, 9, 15, -2, 92, 11 });

            // Assert
            Assert.That(actual, Is.EqualTo(21));
        }
    }
}
