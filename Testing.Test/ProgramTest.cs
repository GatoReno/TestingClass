using System;
using Xunit;

namespace Testing.Test
{
    public class ProgramTest
    {
        [Theory]
        [InlineData(new int[]{1, 3, 4, 5, 3 ,- 6, 8},2)]
        public void CloserToZero_Test(int[] array ,int responseExpected)
        {
            var actual = Program.CloserToZero(array);
            Assert.Equal(responseExpected, actual);
        }


        [Theory]
        [InlineData(new int[] { -4,-3,-1,2,3,6 }, 1)]
        public void CloserToZero_byLambda_Test(int[] array, int responseExpected)
        {
            var actual = Program.CloserToZero_byLambda(array);
            Assert.Equal(responseExpected, actual);
        }
    }
}
