internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập độ dài cạnh của hình vuông:");
        double side = double.Parse(Console.ReadLine());
        double area = side * side;
        Console.WriteLine("Diện tích của hình vuông là: " + area);
        Console.ReadKey();
    }
}

