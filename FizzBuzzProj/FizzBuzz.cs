using System;
using System.Text;

namespace FizzBuzzProj
{
    public class FizzBuzz
    {
        private static StringBuilder _sb = new StringBuilder();
        public static StringBuilder myResult
        {
            get { return _sb; }
            set
            {
                _sb = value;
            }
        }
        public static string CalcFizzBuzz(string Number)
        {
            var nmbr = 0;
            int.TryParse(Number, out nmbr);

            if (nmbr == 0 || nmbr < 0) return "Valeur invalide";
            if (nmbr == 1)
            {
                myResult.AppendLine("1");

                return "Done";
            }
            else
            {
                if (nmbr % 3 == 0 && nmbr % 5 == 0)
                {
                    myResult.AppendLine("FizzBuzz");
                }
                else if (nmbr % 3 == 0)
                {
                    myResult.AppendLine("Fizz");
                }
                else if (nmbr % 5 == 0)
                {
                    myResult.AppendLine("Buzz");
                }
                else
                {
                    myResult.AppendLine(nmbr.ToString());
                }
                FizzBuzz.CalcFizzBuzz(nmbr - 1 + "");

            }
            return "Fail";
        }
    }
}
