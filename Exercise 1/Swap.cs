internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int a = 5, b = 10;
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("Sau khi hoán đổi: a = " + a + ", b = " + b);
        Console.ReadKey();
    }
}

