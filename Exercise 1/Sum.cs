internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập số thứ nhất :");
        Double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhập số thứ hai :");
        Double b = double.Parse(Console.ReadLine());
        Double sum = a + b;
        Console.WriteLine("Tổng của hai số là: " + sum);
        Console.ReadKey();
    }
}
