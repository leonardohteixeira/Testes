public class Program
{
    public static void Main()
    {
        int indice = 12, soma = 0, k = 1;

        while (k < indice)
        {
            k = k + 1;
            soma = soma + k;
        }

        Console.WriteLine($"O valor da soma é: {soma}");
    }
}
