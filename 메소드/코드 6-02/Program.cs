// See https://aka.ms/new-console-template for more information
class Program
{
    class Test
    {
        public int Multi(int x, int y)
        {
            return x * y;
        }
    }

    static void Main(string[] args)
    {
        Test test = new Test();
        Console.WriteLine(test.Multi(52, 273));
        Console.WriteLine(test.Multi(103, 32));
    }
}
