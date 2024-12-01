namespace Bee1002;

class Program
{
    static void Main(string[] args)
    {
        double raio = double.Parse(Console.ReadLine());
        double n = 3.14159;
        double area = Math.Pow(raio, 2) * n;
        Console.WriteLine("A=" + area.ToString("F4"));
    }
}