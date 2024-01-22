namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Add(2, 4);

            //string answer1 = Add(1, 22, true );
            //Console.WriteLine(answer1);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public  double Add(double x, double y)
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
