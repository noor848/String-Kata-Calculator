
using StringAdding;
namespace TestingString
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("",0)]
    
        public void Test1(string InputString,int Actual)
        {
            AddingString c = new AddingString();
            int sum = c.Add1(InputString);
            Assert.Equal(sum, Actual);
        }


        [InlineData("1,2", 3)]
        public void Test3(string InputString, int Actual)
        {
            AddingString c = new AddingString();
            int sum = c.Add1(InputString);
            Assert.Equal(sum, Actual);
        }

        [InlineData("1", 1)]
        public void Test4(string InputString, int Actual)
        {
            AddingString c = new AddingString();
            int sum = c.Add1(InputString);
            Assert.Equal(sum, Actual);
        }


        [InlineData("1,2,3,4,5", 15)]
        public void Test5(string InputString, int Actual)
        {
            AddingString c = new AddingString();
            int sum = c.Add2(InputString);
            Assert.Equal(sum, Actual);
        }

        [InlineData("1\n2,3", 6)]
        public void Test6(string InputString, int Actual)
        {
            AddingString c = new AddingString();
            int sum = c.Add3(InputString);
            Assert.Equal(sum, Actual);
        }

        [InlineData("//;\n1;2", 6)]
        public void Test7(string InputString, int Actual)
        {
            AddingString c = new AddingString();
            int sum = c.Add4(InputString);
            Assert.Equal(sum, Actual);
        }


        [InlineData("1,2,-1", "-1")]
        [InlineData("//;\n1;-2,-4", "-2,-4")]
        public void Test8(string InputString, string Actual)
        {
            AddingString c = new AddingString();
            Action act = () => c.Add5(InputString);
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Negative Number" + Actual, exception.Message);
        }


        [InlineData("1,2,1001", 3)]
        public void Test9(string InputString, int Actual)
        {
            AddingString c = new AddingString();
            int sum = c.Add6(InputString);
            Assert.Equal(sum, Actual);
        }


    }
}