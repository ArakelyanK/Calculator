using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
       
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will prdouble ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Калькудятор\n");
            bool endapp = false;
            while (endapp == false)
            {
                bool endswitch = false;
                string input1 = "";
                string input2 = "";
                string oper = "";
                double res = 0;
                double num1 = 0;
                double num2 = 0;
                Console.WriteLine("Введите первое число");

                input1 = Console.ReadLine();
                while (!double.TryParse(input1, out num1))
                {
                    Console.Write("Введенное значение не является числом. Пожалуйста, введите числовое значение: ");
                    input1 = Console.ReadLine();
                }

                Console.WriteLine("Введено число: " + num1 + "\n");
                Console.WriteLine("Введите второе число");

                input2 = Console.ReadLine();
                while (!double.TryParse(input2, out num2))
                {
                    Console.Write("Введенное значение не является числом. Пожалуйста, введите числовое значение: ");
                    input2 = Console.ReadLine();
                }
                Console.WriteLine("Введено число: " + num2 + "\n");

                while ( endswitch == false)
                {
                    Console.WriteLine("Выберете действие:");
                    Console.WriteLine("\ta - сложение");
                    Console.WriteLine("\ts - вычитание");
                    Console.WriteLine("\tm - умножение");
                    Console.WriteLine("\td - деление");

                    switch (Console.ReadLine())
                    {
                        case "a":
                            res = num1 + num2;
                            Console.WriteLine("Сумма чисел равна " + res);
                            endswitch = true;
                            break;
                        case "s":
                            res = num1 - num2;
                            Console.WriteLine("Разность чисел равна " + res);
                            endswitch = true;
                            break;
                        case "m":
                            res = num1 * num2;
                            Console.WriteLine("Произведение чисел равно " + res);
                            endswitch = true;
                            break;
                        case "d":
                            while (num2 == 0)
                            {
                                Console.WriteLine("Введите неравный нулю делитель");
                                num2 = Convert.ToDouble(Console.ReadLine());
                            }
                            res = num1 / num2;
                            Console.WriteLine("Частное чисел равно " + res);
                            endswitch = true;
                            break;
                    }
                    if (endswitch == false) Console.WriteLine("Введено некорректное значение\n");
                }
                
                Console.WriteLine("Нажмите q для выхода из приложения. Для продолжения работы нажмите любую кнопку...");
               if (Console.ReadLine() == "q")
                {
                    endapp = true;
                }
            }
           
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build input1 console app! 
        }
    }
}
