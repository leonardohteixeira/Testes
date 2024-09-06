public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número:");
        int numero = int.Parse(Console.ReadLine());

        if (PertenceFibonacci(numero))
        {
            Console.WriteLine($"{numero} está na sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não está na sequência de Fibonacci.");
        }
    }

    public static bool PertenceFibonacci(int numero)
    {
        int a = 0;
        int b = 1;

        while (a < numero)
        {
            int prox = a;
            a = b;
            b = prox + b;
        }

        return a == numero;
    }
}