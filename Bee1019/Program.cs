namespace Bee1019;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int h, m, s;
        h = n / 3600;
        m = (n % 3600) / 60;
        s = (n % 3600) % 60;
        Console.WriteLine($"{h}:{m}:{s}");
    }
}