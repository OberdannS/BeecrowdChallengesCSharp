namespace Bee1011;

class Program
{
    static void Main(string[] args)
    {
        int raio = int.Parse(Console.ReadLine());
        double volume = (((double) 4 / 3) * 3.14159) * Math.Pow(raio, 3);
        Console.WriteLine("VOLUME = " + volume.ToString("F3"));
    }
}