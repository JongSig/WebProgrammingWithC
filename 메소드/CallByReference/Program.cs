// See https://aka.ms/new-console-template for more information
class Program
{
    static void Swap(ref int a, ref int b)
    {
        int temp = b;
        b = a;
        a = temp;
        Console.WriteLine("Swap : a = {0}, b = {1}, b = {2}", a, b, temp);
    }

    static void Main(string[] args)
    {
        int a = 40;
        int b = 10;

        Console.WriteLine("Swap before : a = {0}, b = {1}", a, b);

        Swap(ref a, ref b);

        Console.WriteLine("Swap after : a = {0}, b = {1}", a, b);
    }
}
