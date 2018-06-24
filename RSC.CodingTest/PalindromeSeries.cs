
namespace RSC.CodingTest
{
    public class PalindromeSeries
    {

        public bool IsPalindrome(string number)
        {
            var length = number.Length;
            var elementsToCheck = length / 2;
            var endStartIndex = length ;
            for (var i = 0; i < elementsToCheck; i++ )
            {
                endStartIndex = endStartIndex - 1;
                if (number.Substring(i,1) != number.Substring(endStartIndex,1))
                {
                    return false;
                }
            }
            return true;

        }



    }
}
