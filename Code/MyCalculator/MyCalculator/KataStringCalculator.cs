using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public static class KataStringCalculator
    {
        public static int Add(string numbers, char separator = ',')
        {
            var rtnValue = 0;

            if (!string.IsNullOrEmpty(numbers))
            {
                var splittedNumbers = numbers.Split(separator);
                foreach (var stringNumber in splittedNumbers)
                {
                    int numberToAdd;
                    if (int.TryParse(stringNumber, out numberToAdd))
                        rtnValue += rtnValue;
                }
            }

            return rtnValue;
        }
    }
}
