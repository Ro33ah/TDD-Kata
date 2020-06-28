using System;
using System.Collections.Generic;

namespace FizzBuzzCode

{
    public class FizzBuzz
    {
        public IEnumerable<string> ReturnString(int maxNumber)
        {
            var result = new List<string>();

            for (int i = 1; i <= maxNumber ; i++)
            {
                if (i % 3 == 0)
                {
                    result.Add("fizz");
                }
                else if(i % 5 == 0) 
                {
                    result.Add("buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
            //throw new NotImplementedException();
        }

        static void Main()
        {
        }
    }
}
