public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite uma palavra:");
        string palavra = Console.ReadLine();

        int minuscula = 0;
        int maiuscula = 0;

        foreach (char p in palavra)
        {
            if (p == 'a')
            {
                minuscula++;
            }
            else if (p == 'A')
            {
                maiuscula++;
            }
        }

        if (maiuscula < 0 || minuscula < 0)
        {
            Console.WriteLine("Não existe letra 'a' na palavra.");
        }
        else
        {
            Console.WriteLine($"A palavra tem {maiuscula} letras 'A' maiúsculas.");
            Console.WriteLine($"A palavra tem {minuscula} letras 'a' minusculas.");
        }
    }
}
