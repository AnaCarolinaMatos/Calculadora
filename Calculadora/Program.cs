using System.ComponentModel.Design;
using System.Linq;
public static class Program
{
    public static void Main(String[] args)
    {
        bool estaCalculando = true;
        while (estaCalculando)
        {
            var opcao = Menu();

            Console.WriteLine("Digite o primeiro número:");
            decimal numero1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            decimal numero2 = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = CalculaResultado(opcao, numero1, numero2);

            Console.WriteLine($"Resultado: {resultado}\n");

            Console.WriteLine("Deseja continuar?");
            Console.WriteLine("Digite uma opção:\n");


            Console.WriteLine("1 - SIM\n2 - NÃO\n");
            int continuar = Convert.ToInt32(Console.ReadLine());

            if( continuar == 2)
            {
                estaCalculando = false;
            }

        }

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Obrigada!");
        Console.ReadLine();
    }


    private static int Menu() 
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Seja bem-vindo a minha calculadora básica");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite uma opção:\n");


        Console.WriteLine("1 - Somar\n2 - Subtrair\n3 - Dividir\n4 - Multiplicar\n");
        int opcao = Convert.ToInt32(Console.ReadLine());

        return opcao;

    }

    private static decimal CalculaResultado(int opcao, decimal numero1, decimal numero2) 
    {

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

        return resultado;


    }

    








}