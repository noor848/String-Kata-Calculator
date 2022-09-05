namespace StringAdding
{
    public class AddingString
    {
        public const int UpperLimit = 1000;
        public int Add(string StringInput)
        {
            int sum = 0;
            List<int> NumbersList;
            if (string.IsNullOrEmpty(StringInput))
            {
                return 0;
            }

            if (StringInput.StartsWith("//"))
            {
                ///"//; \n 1;2" 
                var SplitString = StringInput.Split(new char[] { '\n' },
                 StringInput.Length,StringSplitOptions.RemoveEmptyEntries);
                var BackSepration = SplitString[0].Trim('/');
                NumbersList = SplitString[1].Split(BackSepration, StringInput.Length, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse)?.ToList();
            }
            else
            {
                NumbersList = StringInput.Split(new char[] { ',', '\n', ';' }, StringInput.Length,StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse)?.ToList();
            }

            List<int> NegativeNumbers = new List<int>();
            foreach (var num in NumbersList)
            {
                if (num < 0)
                {
                    NegativeNumbers.Add(num);
                }
                else if (num <= 1000)
                {
                    sum += num;
                }
            }

            if (NegativeNumbers.Any())
            {
                throw new Exception("Negative Number" + String.Join(",", NegativeNumbers));
            }

            return sum;
        }

    }
}
