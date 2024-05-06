namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {

            Add(2, 4);

            Add(3.8m, 4.9m);

            
            decimal one=.50m;
            decimal two=.50m;

            var addition = one + two;

            var dollars = addition == 1;

            Console.WriteLine(dollars);
        }
        static void Add(int one, int two)
        {
            var addition = (one + two);

            Console.WriteLine(addition);
        }
        static void Add(decimal one, decimal two)
        {
            var addition = one + two;

            Console.WriteLine(addition);
        }
        //static string Add(int one, int two, bool dollars)
        //{

        //    var addition = one + two;

        //    dollars = addition == 1;

        //    Console.WriteLine(dollars);

        //    if (dollars = true)
        //    {


        //        Console.WriteLine($"{addition} dollars");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{addition} dollar");
        //    }

        }
    }
