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
            String[] strlist = StringInput.Split(new char[]{','} , StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            foreach(var str in strlist)
            {
                sum +=Int16.Parse(str);    
            }

            return sum;
        }
    }
}