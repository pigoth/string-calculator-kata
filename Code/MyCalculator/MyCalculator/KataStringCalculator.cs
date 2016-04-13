using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public static class KataStringCalculator
    {

        public static string WrongInputFormat = "Wrong input: {0}";

        public static int Add(string numbers, char firstSeparator = ',', char secondSeparator = '\n')
        {
            var rtnValue = 0;

            if (!string.IsNullOrEmpty(numbers))
            {
                var splittedNumbers = numbers.Split(firstSeparator, secondSeparator);

                if(splittedNumbers.Contains(string.Empty))
                    throw new ArgumentException(string.Format(WrongInputFormat, numbers) );


                foreach (var stringNumber in splittedNumbers)
                {
                    int numberToAdd;
                    if (int.TryParse(stringNumber, out numberToAdd))
                        rtnValue += numberToAdd;
                }
            }

            return rtnValue;
        }
    }
}
