internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập số nguyên:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Kích thước của kiểu dữ liệu int là: " + sizeof(int) + " bytes");
    }
}