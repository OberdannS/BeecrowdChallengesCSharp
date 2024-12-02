namespace Bee1018;

class Program
{
    static void Main(string[] args)
    {
        int res;
        int valor = int.Parse(Console.ReadLine());
        Console.WriteLine(valor);
        Console.WriteLine(valor/100 + " nota(s) de R$ 100,00");
        res = valor % 100;
        Console.WriteLine(res/50 + " nota(s) de R$ 50,00");
        res %= 50;
        Console.WriteLine(res/20 + " nota(s) de R$ 20,00");
        res %= 20;
        Console.WriteLine(res/10 + " nota(s) de R$ 10,00");
        res %= 10;
        Console.WriteLine(res/5 + " nota(s) de R$ 5,00");
        res %= 5;
        Console.WriteLine(res/2 + " nota(s) de R$ 2,00");
        res %= 2;
        Console.WriteLine(res/1 + " nota(s) de R$ 1,00");
    }
}