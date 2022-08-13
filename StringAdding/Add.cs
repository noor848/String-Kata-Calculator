namespace StringAdding
{
    public class Add
    {
        public int CalculatingString(string StringInput)
        {
            String[] NumbersList = {};
            String[] strlist = {};
            int sum = 0;

            if (string.IsNullOrEmpty(StringInput))
            {
                return 0;
            }

            if (StringInput.StartsWith("//"))
            {
                ///"//;\n1;2" 
                NumbersList = StringInput.Split(new char[] { '\n' },
                StringInput.Length, StringSplitOptions.RemoveEmptyEntries);
                strlist = NumbersList[1].Split(new char[] { ',', '\n', ';' }, StringInput.Length, StringSplitOptions.RemoveEmptyEntries);
                foreach (var str in strlist)
                {
                    sum += Int16.Parse(str);
                }

            }
            else
            {
                strlist = StringInput.Split(new char[] { ',', '\n', ';' }, StringInput.Length, StringSplitOptions.RemoveEmptyEntries);
                foreach (var str in strlist)
                {
                    sum += Int16.Parse(str);
                }
            }
          
            return sum;
        }
    }
}
