using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Faça um script que solicite dois números 
                e ao final mostre a soma, divisão, multiplicação; 
            */

            decimal valor_um;
            decimal valor_dois;

            // 1 - Solicitar informações
            Console.WriteLine("Bem vindo a calculadora rudimentar");

            Console.WriteLine("Digite o primeiro valor: ");
            valor_um = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valor_dois = decimal.Parse(Console.ReadLine());

            // Limpa a tela
            Console.Clear();

            // 2 - Calcular os valores
            decimal soma =  valor_um + valor_dois;
            decimal multiplicacao = valor_um * valor_dois;
            decimal subtracao = valor_um - valor_dois;
            decimal divisao = valor_um / valor_dois;

            // 3 - Mostrar o Resultado
            Console.WriteLine("A soma dos números é: " + soma);
            Console.WriteLine($"A produto dos números é: {multiplicacao}");
            Console.WriteLine($"A resto dos números é: {subtracao}");
            Console.WriteLine("A quosciente dos números é: " + divisao);

            // Espera o usuário finalizar o programa
            Console.ReadKey();
        }
    }
}
