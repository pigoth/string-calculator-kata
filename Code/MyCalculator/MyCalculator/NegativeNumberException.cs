using System;

namespace MyCalculator
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(int number)
            :base(string.Format("Not allowed negative number: {0}", number))
        {
            
        }
    }
}