// See https://aka.ms/new-console-template for more information
class Program
{
    class Product
    {
        public static int counter = 0;
        public int id;
        public string name;
        public int price;
        public static int totalPrice = 0;

        public Product(string name, int price)
        {
            Product.counter = counter + 1;
            this.id = counter;
            this.name = name;
            this.price = price;
            Product.totalPrice += price;
        }
    }

    static void Main(string[] args)
    {
        Product productA = new Product("감자", 2000);
        Product productB = new Product("고구마", 3000);

        Console.WriteLine(productA.id + ":" + productA.name);
        Console.WriteLine(productB.id + ":" + productB.name);
        Console.WriteLine(Product.counter + "개 생성되었으며, 가격의 합은 " + Product.totalPrice + "원 입니다.");
    }
}
