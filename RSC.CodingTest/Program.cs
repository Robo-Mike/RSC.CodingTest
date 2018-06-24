using System;
using System.Linq;

namespace RSC.CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Please enter a whole number. Click on the screen to pause.");
                string originalWholeNumber = Console.ReadLine(); 
                WriteNumberSeries(originalWholeNumber);
            } while (true);
           
            
        }

        static private void WriteNumberSeries(string number)
        {
            string result = null;
            int itemCount = 0;
            var series = new PalindromeSeries();
            var numericString = new NumericString();
            try
            {
                do
                {
                    itemCount++;
                    var reversedNumber = new string(number.Reverse().ToArray());
                    result = numericString.Add(number, reversedNumber);
                    Console.WriteLine("{0}. {1} + {2} = {3}", itemCount.ToString(), number, reversedNumber, result);
                    number = result;
                    //todo remove test catch
                } while (!series.IsPalindrome(result));
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Not enough memory to complete number series");
            }
            

        }


    }
}
