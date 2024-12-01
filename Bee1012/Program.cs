namespace Bee1012;

class Program
{
    static void Main(string[] args)
    {
        string[] abc = Console.ReadLine().Split(' ');
        double a = double.Parse(abc[0]);
        double b = double.Parse(abc[1]);
        double c = double.Parse(abc[2]);
        double triangulo = (a * c) / 2;
        double circulo = Math.Pow(c, 2) * 3.14159;
        double trapezio = (a + b) * (c / 2);
        double quadrado = Math.Pow(b, 2);
        double retangulo = a * b;
        Console.WriteLine("TRIANGULO: {0}", triangulo.ToString("F3"));
        Console.WriteLine("CIRCULO: {0}", circulo.ToString("F3"));
        Console.WriteLine("TRAPEZIO: {0}", trapezio.ToString("F3"));
        Console.WriteLine("QUADRADO: {0}", quadrado.ToString("F3"));
        Console.WriteLine("RETANGULO: {0}", retangulo.ToString("F3"));
    }
}