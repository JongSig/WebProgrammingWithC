// See https://aka.ms/new-console-template for more information
class Program
{
    class Test
    {
        public void Print()
        {
            Console.WriteLine("Print() 메소드가 호출되었습니다.");
        }
    }

    static void Main(string[] args)
    {
        Test test = new Test();
        test.Print();
        test.Print();
        test.Print();
    }
}