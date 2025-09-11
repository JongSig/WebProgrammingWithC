// See https://aka.ms/new-console-template for more information
class Program
{
    class MyMath
    {
        public static int Abs(int input)
        {
            if (input < 0) { return -input; }
            else { return input; }
        }
        public static double Abs(double input)
        {
            if (input < 0) { return -input; }
            else { return input; }
        }
        public static double Abs(long input)
        {
            if (input < 0) { return -input; }
            else { return input; }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine(MyMath.Abs(52));
        Console.WriteLine(MyMath.Abs(-273));
        Console.WriteLine(MyMath.Abs(52.273));
        Console.WriteLine(MyMath.Abs(-32.103));
        Console.WriteLine(MyMath.Abs(52273123456789));
        Console.WriteLine(MyMath.Abs(-52273123456789));
    }
}
