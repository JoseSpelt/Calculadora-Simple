using System;


class Calculadora
{
    static void Main()
    {
        Console.WriteLine("Calculadora Simple");

        Console.WriteLine("Ingrese el primer numero: ");

        double num1;

        while (!double.TryParse(Console.ReadLine(),out num1))
        {
            Console.WriteLine("Ingrese un numero valido");
        }

        Console.WriteLine("Ingrese el operador (+,-,*,/)");

        char operador = Console.ReadLine()[0];

        Console.WriteLine("Ingrese el segundo numero: ");

        double num2;

        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Ingrese un numero entero");
        }


        double resultado = 0;

        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    resultado = num2 / num1;
                }
                else
                {
                    Console.WriteLine("Error Division, no se permite division entre 0");
                    return;
                }
                break;
            default: 
                Console.WriteLine("Ingrese un operador valido");
                break;
        }

        Console.WriteLine("El resultado de la operacion es: " + resultado);
    }
}
