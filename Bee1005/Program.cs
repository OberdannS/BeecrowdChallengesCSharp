namespace Bee1005;

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        a *= 3.5;
        b *= 7.5;
        double media = (a + b) / 11;
        Console.WriteLine("MEDIA = " + media.ToString("F5"));
    }
}