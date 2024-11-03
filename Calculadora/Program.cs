using System.Linq;
public static class Program
{
    public static void Main(String[] args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Seja bem-vindo a minha calculadora básica");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite uma opção:\n");


        Console.WriteLine("1 - Somar\n2 - Subtrair\n3 - Dividir\n4 - Multiplicar\n");
        int opcao = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o primeiro número:");
        decimal numero1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        decimal numero2 = Convert.ToDecimal(Console.ReadLine());
        decimal resultado = 0;

        if (opcao == 1)
        {
            resultado = numero1 + numero2;
        }

        if (opcao == 2)
        {
            resultado = numero1 - numero2;
        }

        if (opcao == 3)
        {
            resultado = numero1 / numero2;
        }

        if (opcao == 4)
        {
            resultado = numero1 * numero2;
        }

        Console.WriteLine($"Resultado: {resultado}\n");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Obrigada!");
        Console.ReadLine();

    }

}