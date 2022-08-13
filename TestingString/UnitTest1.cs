
using StringAdding;
namespace TestingString
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1,2,-1","-1")]
        [InlineData("//;\n1;-2,-4", "-2,-4")]
        public void Test1(string InputString,string Actual)
        {
            Add c = new Add();
            Action act = () => c.CalculatingString(InputString);
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Negative Number"+ Actual, exception.Message);
        }

        [Theory]
        [InlineData("1,2,1001",3)]
        public void Test2(string InputString, int Actual)
        {
            Add c = new Add();
            int sum= c.CalculatingString(InputString);
            Assert.Equal(sum,Actual);
        }


    }
}
