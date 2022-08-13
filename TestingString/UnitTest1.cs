
using StringAdding;
namespace TestingString
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1,2,2,1")]
        public void Test1(string InputString)
        {
            Add c = new Add();
            int sum = c.CalculatingString(InputString);
            Assert.Equal(8, sum);
          
        }
    }
}
