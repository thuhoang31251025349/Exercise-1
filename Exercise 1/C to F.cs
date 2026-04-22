internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập nhiệt độ (°C):");
        Double celsius = double.Parse(Console.ReadLine());
        Double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine(celsius + "°C = " + fahrenheit + "°F");
        Console.ReadKey();
    }
}

