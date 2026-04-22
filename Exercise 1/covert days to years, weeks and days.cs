internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập số ngày:");
        int days = int.Parse(Console.ReadLine());
        int years = days / 365;
        int weeks = (days % 365) / 7;
        int remainingDays = (days % 365) % 7;
        Console.WriteLine(days + " ngày = " + years + " năm, " + weeks + " tuần, " + remainingDays + " ngày");
        Console.ReadKey();
    }
}

