namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1,1));
            Console.WriteLine(Add(2.5,2.5));
            Console.WriteLine(Add(1,0,true ));
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static string Add(int x, int y ,bool isMoney)
        {
            var sum = x + y;

            if (isMoney == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isMoney == true && sum == 1)
            {
                return $"{sum} dollar";
            }

            else
            {
                return $"{sum}";
            }
        }
    }
}
