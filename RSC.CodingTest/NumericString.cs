using System.Numerics;

namespace RSC.CodingTest
{
    public class NumericString
    {
        public string Add(string wholeNumber1, string wholeNumber2)
        {
            var number1 = BigInteger.Parse(wholeNumber1);
            var number2 = BigInteger.Parse(wholeNumber2);
            var result = number1 + number2;
            return result.ToString();

        }
    }
}
