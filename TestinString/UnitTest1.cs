using StringAdding;

namespace TestingString
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("1,2", 3)]
        [InlineData("1", 1)]
        [InlineData("1,2,3,4,5", 15)]
        [InlineData("1\n2,3", 6)]
        [InlineData("//;\n1;2", 3)]
        [InlineData("1,2,1001", 3)]
        public void TestStringWithDifferentDelimeterSeperated(string InputString, int Actual)
        {
            AddingString c = new AddingString();
            int sum = c.Add(InputString);
            Assert.Equal(sum, Actual);
        }

        [Theory]
        [InlineData("1,2,-1", "-1")]
        [InlineData("//;\n1;-2,-4", "-2,-4")]
        public void TestingWithNegativeNumber(string InputString, string Actual)
        {
            AddingString c = new AddingString();
            Action act = () => c.Add5(InputString);
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Negative Number" + Actual, exception.Message);
        }

    }
}