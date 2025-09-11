// See https://aka.ms/new-console-template for more information
class Program
{
    class Test
    {
        public int Power(int x)
        {
            return x * x;
        }
    }

    static void Main(string[] args)
    {
        Test test = new Test();
        Console.WriteLine(test.Power(10));
        Console.WriteLine(test.Power(20));
    }
}

