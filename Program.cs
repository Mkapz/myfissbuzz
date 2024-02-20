namespace Fizzbuss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int j= 5; j <= 100; j++)
            {
                string results = "";
                if (j % 3 == 0) results = "Fizz";

                if (j % 5 == 0) results = results + "Buzz";

                if (results.Length == 0) results = j.ToString();
                Console.WriteLine(results);


            }

        }
    }
}
