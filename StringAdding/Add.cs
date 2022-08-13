namespace StringAdding
{
    public class Add
    {
        public int CalculatingString(string StringInput)
        {           
            int sum = 0;
            List<int> NumbersList;
            if (string.IsNullOrEmpty(StringInput))
            {
                return 0;
            }

            if (StringInput.StartsWith("//"))
            {
                ///"//;\n1;2" 
                var SplitString = StringInput.Split(new char[] { '\n' },
                 StringInput.Length, StringSplitOptions.RemoveEmptyEntries);
                NumbersList = SplitString[1].Split(new char[] { ',', '\n', ';' }, StringInput.Length, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse)?.ToList();

            }
            else
            {
                NumbersList = StringInput.Split(new char[] { ',', '\n', ';' }, StringInput.Length,
           StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse)?.ToList();
            }
      
            List<int> NegativeNumbers=new List<int>();
            foreach (var num in NumbersList)
                {
                if (num < 0)
                {
                    NegativeNumbers.Add(num);
                }
                if (num <= 1000)
                {
                    sum += num;
                }
            }

            if (NegativeNumbers.Any())
            {
                throw new ArgumentException("Negative Number" + String.Join(",", NegativeNumbers));
            }

            return sum;
        }
        }
    }
