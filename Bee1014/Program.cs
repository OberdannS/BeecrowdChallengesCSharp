namespace Bee1014;

class Program
{
    static void Main(string[] args)
    {
        int km = int.Parse(Console.ReadLine());
        double litros = double.Parse(Console.ReadLine());
        double kml = km / litros;
        Console.WriteLine(kml.ToString("F3") + " km/l");
    }
}