
using StringAdding;
namespace TestingString
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("",0)]
        [InlineData("1,2", 3)]
        [InlineData("1", 1)]
        [InlineData("1,2,3,4,5", 15)]
        public void TestStringWithCommaSeperated(string InputString,int Actual)
        {
            AddingString c = new AddingString();
            int sum = c.Add1(InputString);
            Assert.Equal(sum, Actual);
        }

        [Theory]
        [InlineData("1\n2,3", 6)]
        public void TestStringwithNewLineSeperated(string InputString, int Actual)
        {
            AddingString c = new AddingString();
            int sum = c.Add3(InputString);
            Assert.Equal(sum, Actual);
        }

        [Theory]
        [InlineData("//;\n1;2", 6)]
        public void TestStringwithDifferentTypeOfDelimeterSeperated(string InputString, int Actual)
        {
            AddingString c = new AddingString();
            int sum = c.Add4(InputString);
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

        [Theory]
        [InlineData("1,2,1001", 3)]
        public void TestExcludingRangeOfNumber(string InputString, int Actual)
        {
            AddingString c = new AddingString();
            int sum = c.Add6(InputString);
            Assert.Equal(sum, Actual);
        }


    }
}