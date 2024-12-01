namespace Bee1010;

class Program
{
    static void Main(string[] args)
    {
        string[] linha1 = Console.ReadLine().Split(' ');
        string[] linha2 = Console.ReadLine().Split(' ');
        int codigo1 = int.Parse(linha1[0]);
        int npecas1  = int.Parse(linha1[1]);
        double valor1 = double.Parse(linha1[2]);
        int codigo2 = int.Parse(linha2[0]);
        int npecas2  = int.Parse(linha2[1]);
        double valor2 = double.Parse(linha2[2]);
        double total = (npecas1 * valor1) + (npecas2 * valor2);
        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
    }
}