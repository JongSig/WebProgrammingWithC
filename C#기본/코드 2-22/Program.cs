// See https://aka.ms/new-console-template for more information
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
        Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);
    }
}
