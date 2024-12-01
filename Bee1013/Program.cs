namespace Bee1013;

class Program
{
    static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(' ');
        int a = int.Parse(vet[0]);
        int b = int.Parse(vet[1]);
        int c = int.Parse(vet[2]);
        int maiorAB = (a + b + Math.Abs(a - b)) / 2;
        int maiorBC = (b + c + Math.Abs(b - c)) / 2;
        if (maiorAB > maiorBC)
        {
            Console.WriteLine(maiorAB + " eh o maior");                
        }
        else
        {
            Console.WriteLine(maiorBC + " eh o maior");
        }
    }
}