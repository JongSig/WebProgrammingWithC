// See https://aka.ms/new-console-template for more information
class Program
{
    class Test
    {
        public long Multiply(int min, int max)
        {
            long output = 1;
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
        Console.WriteLine(test.Multiply(1, 33));
    }
}
