namespace Bee1017;

class Program
{
    static void Main(string[] args)
    {
        int tempo = int.Parse(Console.ReadLine());
        int velocidade = int.Parse(Console.ReadLine());
        int distancia = tempo * velocidade;
        double kml = (double) distancia / 12;
        Console.WriteLine(kml.ToString("F3"));
    }
}