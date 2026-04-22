internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập một ký tự:");
        char character = char.Parse(Console.ReadLine());
        int ascii = (int)character;
        Console.WriteLine("Mã ASCII của ký tự '" + character + "' là: " + ascii);
        Console.ReadKey();
    }
}

