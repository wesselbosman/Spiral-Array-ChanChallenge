using System;
using System.Text;
using Core;
using Shouldly;
using Xunit;

namespace ChanChallenge
{
    public class SpiralArrayTests
    {
        [Fact]
        public void SpiralArray_Given3and5_ShouldReturn_SpiralArray()
        {
            // Arrange
            var expected = new [,] {{1, 2, 3, 4, 5}, {12, 13, 14, 15, 6}, {11, 10, 9, 8, 7}};
            var spiralArray = new SpiralArray(3, 5);

            // Act
            var result = spiralArray.Value();

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void SpiralArray_Given2and6_ShouldReturn_SpiralArray()
        {
            // Arrange
            var expected = new[,] { { 1, 2}, {12,3}, {11,4}, {10,5}, {9,6}, {8,7} };
            var spiralArray = new SpiralArray(6, 2);

            // Act
            var result = spiralArray.Value();

            // Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void SpiralArray_Given12and60_ShouldNotThrowIndexOutOfRangeException()
        {
            // Arrange
            var spiralArray = new SpiralArray(12, 60);

            // Act, Assert
            Should.NotThrow(() => spiralArray.Value());
        }
    }
}
