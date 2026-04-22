internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập số thứ nhất :");
        Double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhập số thứ hai :");
        Double b = double.Parse(Console.ReadLine());
        Double product = a * b;
        Console.WriteLine("Tích của hai số là: " + product);
        Console.ReadKey();
    }
}
