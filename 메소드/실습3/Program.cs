// See https://aka.ms/new-console-template for more information
namespace AccessModifier1
{
    class AccessTest
    {
        public int num;

        public AccessTest(int num)
        {
            this.num = num;
        }
        public void Show()
        {
            Console.WriteLine("num: " + num);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AccessTest accesstest = new AccessTest(50);

            accesstest.Show();
        }
    }
}
