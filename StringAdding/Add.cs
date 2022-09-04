namespace StringAdding
{
    public class AddString
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
        public int CalculatingStringFirstSolution(string StringInput)
        {
            if (string.IsNullOrEmpty(StringInput))
            {
                return 0;
            }
            var NumbList = StringInput.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();


            int sum = 0;
            foreach (var num in NumbList)
            {
                sum += num;
            }

            return sum;
        }
        public int CalculatingStringSecondSolution(string StringInput)
        {
            if (string.IsNullOrEmpty(StringInput))
            {
                return 0;
            }

            var NumbList = StringInput.Split(new char[] { ',' }, StringInput.Length, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();

            int sum = 0;
            foreach (var num in NumbList)
            {
                sum += num;
            }

            return sum;
        }
        public int CalculatingStringThirdSolution(string StringInput)
    {
        if (string.IsNullOrEmpty(StringInput))
        {
            return 0;
        }

        var NumbList = StringInput.Split(new char[] { ',', '\n' }, StringInput.Length, 
            StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToList();

        int sum = 0;
        foreach (var num in NumbList)
        {
            sum += num;
        }

        return sum;
    }
       public int CalculatingStringFourthSolution(string StringInput)
        {
            String[] NumbersList;
           
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
                var strlist = NumbersList[1].Split(new char[] { ',', '\n', ';' }, StringInput.Length, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse);
                    ;
                foreach (var num in strlist)
                {
                    sum += num ;
                }
            }

            return sum;
        }
        public int CalculatingStringFifthSolution(string StringInput)
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

                List<int> NegativeNumbers = new List<int>();
                foreach (var num in NumbersList)
                {
                    if (num < 0)
                    {
                        NegativeNumbers.Add(num);
                    }
                    sum += num;

                }
                if (NegativeNumbers.Any())
                {
                    throw new ArgumentException("Negative Number" + String.Join(",", NegativeNumbers));
                }

                return sum;
        }
        public int CalculatingStringSixthSolution(string StringInput)
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

            List<int> NegativeNumbers = new List<int>();
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
