namespace Bee1008;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        double valueHours = double.Parse(Console.ReadLine());
        double salary = hours * valueHours;
        Console.WriteLine("NUMBER = {0}", number);
        Console.WriteLine("SALARY = U$ {0}", salary.ToString("F2"));
    }
}