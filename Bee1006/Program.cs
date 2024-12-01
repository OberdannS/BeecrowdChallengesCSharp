namespace Bee1006;

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        a *= 2;
        b *= 3;
        c *= 5;
        double media = (a + b + c) / 10;
        Console.WriteLine("MEDIA = " + media.ToString("F1"));
    }
}