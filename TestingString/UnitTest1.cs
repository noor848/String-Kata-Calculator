
using StringAdding;
namespace TestingString
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("",0)]
        public void Test1(string InputString,int Actual)
        {
            Add c = new Add();
            int sum = c.CalculatingString(InputString);
            Assert.Equal(Actual, sum);
          
        }
    }
}
