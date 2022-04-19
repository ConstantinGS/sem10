using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        { // Даны два числа a, b. Сложите их, используя только операции инкремента и декремента.


            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            Recursion();
          


            void Recursion()
            {
                if (a>0)
                {
                    a--;
                    b++;
                    Recursion();
                }
                else
                {
                    Console.WriteLine($"Сумма чисел равна: {b} ");
                    return;
                } 
                
            }

        }

    }
}