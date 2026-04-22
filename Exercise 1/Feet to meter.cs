internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập số feet:");
        Double feet = double.Parse(Console.ReadLine());
        Double meters = feet * 0.3048;
        Console.WriteLine(feet + " feet = " + meters + " meters");
        Console.ReadKey();
    }
}

