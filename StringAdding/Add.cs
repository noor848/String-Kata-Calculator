namespace StringAdding
{
    public class Add
    {
        public int CalculatingString(string StringInput)
        {
            if (string.IsNullOrEmpty(StringInput))
            {
                return 0;
            }
            var NumList = StringInput.Split(new char[]{','}, StringInput.Length, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)?.ToList();
            int sum = 0;
            foreach(var num in NumList)
            {
                sum +=num;    
            }
            return sum;
        }
    }
}
