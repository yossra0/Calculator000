﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an operator (+, -, *, /):");
        char operation = Console.ReadLine()[0];

        double result=0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
                case '/':
                result = num1 / num2;
                break;
           
        }

        Console.WriteLine($"Result: {result}");
    }
}