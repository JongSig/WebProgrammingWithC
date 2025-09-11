// See https://aka.ms/new-console-template for more information
class Program
{
    class Test
    {
        public int Multiply(int min, int max)
        {
            int output = 1;
            for (int i = min; i <= max; i++)
            {
                output *= i;
            }
            return output;
        }
    }

    static void Main(string[] args)
    {
        Test test = new Test();
        Console.WriteLine(test.Multiply(1, 10));
    }
}