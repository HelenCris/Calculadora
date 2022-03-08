using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //input do primeiro número
            Console.WriteLine("Escreva um número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            //input do segundo número
            Console.WriteLine("Escreva um segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            //escolha da operação
            Console.WriteLine("MENU:");
            Console.WriteLine("+ para soma");
            Console.WriteLine("- para subtração");
            Console.WriteLine("* para multiplicação");
            Console.WriteLine("% para divisão");
            Console.WriteLine("Escolha o tipo de operação que você gostaria de realizar: ");
            string operacao = Console.ReadLine();

            //resultado das operações
            int soma = num1 + num2;
            int subtracao = num1 - num2;
            int multiplicacao = num1 * num2;
            int divisao = num1 / num2;


            if (operacao == "+") 
            { 
                Console.WriteLine($"O resultado da soma é {soma}");
            }
            else if (operacao == "-") 
            { 
                Console.WriteLine($"O resultado da subtração é {subtracao}");
            }
            else if (operacao == "*") 
            { 
                Console.WriteLine($"O resultado da multiplicação é {multiplicacao}");
            }
            else if (operacao == "/") 
            { 
                Console.WriteLine($"O resultado da divisão é {divisao}");
            }
            else 
            {
                Console.WriteLine("Operador inválido! Tente Novamente");
            }
        }
    }
}
