namespace Bee1020;

class Program
{
    static void Main(string[] args)
    {
        int dias = int.Parse(Console.ReadLine());
        int ano, mes, dia;
        ano = dias / 365;
        mes = (dias % 365) / 30;
        dia = (dias % 365) % 30;
        Console.WriteLine($"{ano} ano(s)");
        Console.WriteLine($"{mes} mes(es)");
        Console.WriteLine($"{dia} dia(s)");
    }
}