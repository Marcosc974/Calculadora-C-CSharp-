using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, total=0;
            string ope;
            Console.WriteLine("Entre com o Operador desejado: + soma, - sutração, * Multiplicação, / Divisão, X para sair");
            ope = Console.ReadLine();
            while (ope.Equals("+") || ope.Equals("-") || ope.Equals("*") || ope.Equals("/")) {
                Console.WriteLine("Digite o valor de num 1: ");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de num 2: ");
                num2 = double.Parse(Console.ReadLine());
                switch (ope)
                {
                    case "+":
                        total = num1 + num2;
                        break;
                    case "-":
                        total = num1 - num2;
                        break;
                    case "*":
                        total = num1 * num2;
                        break;
                    case "/":
                        total = num1 / num2;
                        break;
                }
                Console.WriteLine("O resultado é: " + total);
                Console.WriteLine("Entre com o Operador desejado: + soma, - sutração, * Multiplicação, / Divisão,  X para sair");
                ope = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
