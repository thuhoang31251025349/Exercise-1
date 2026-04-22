internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập bán kính của hình tròn:");
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r;
        Console.WriteLine("Diện tích của hình tròn là: " + area);
        Console.ReadKey();
    }
}

