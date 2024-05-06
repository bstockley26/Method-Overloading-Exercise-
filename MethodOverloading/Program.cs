namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            var b = 1;

            var answer =Add(a, b);
            Console.WriteLine($"Integer: {answer}");

            var c = 3.6m;
            var d = 4.9m;
            var decimalAnswer=Add(c, d);
            Console.WriteLine($"decimal: {decimalAnswer}");

            string thirdAnswer=Add(a,b,true);

            Console.WriteLine(thirdAnswer);
            
        }
        static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

            static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;

            
        }
        static string Add(int numOne, int numTwo, bool isTrueOrFalse)
        {
            var sum = numOne + numTwo;

            

            if (isTrueOrFalse==true && sum > 1)
            {

               return $"{sum} dollars";
            }
            else if (isTrueOrFalse == true && sum ==1)
            {
                return $"{sum} dollar";
            }
            else if (isTrueOrFalse == true && sum < 1)
            {
                return $"{sum} cents";
            }
            else
            {
                return sum.ToString();
            }

        }
    }
}