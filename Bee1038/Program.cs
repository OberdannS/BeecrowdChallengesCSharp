namespace Bee1038;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int cod = int.Parse(input[0]);
        int qtd = int.Parse(input[1]);
        double total = 0;
        switch (cod)
        {
            case 1:
            {
                total = qtd * 4.00;
                break;
            }
            case 2:
            {
                total = qtd * 4.50;
                break;
            }
            case 3:
            {
                total = qtd * 5.00;
                break;
            }
            case 4:
            {
                total = qtd * 2.00;
                break;
            }
            case 5:
            {
                total = qtd * 1.50;
                break;
            }
        }
        Console.WriteLine("Total: R$ " + total.ToString("F2"));
    }
}