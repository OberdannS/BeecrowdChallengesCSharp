namespace Bee1036;

class Program
{
    static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(' ');
        double a = double.Parse(vet[0]);
        double b = double.Parse(vet[1]);
        double c = double.Parse(vet[2]);
        double delta = Math.Pow(b, 2) - (4 * a * c);
        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        if (delta >= 0 && a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine($"R1 = {x1.ToString("F5")}");
            Console.WriteLine($"R2 = {x2.ToString("F5")}");
        }
        else
        {
            Console.WriteLine("Impossivel calcular");
        }
    }
}