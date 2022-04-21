using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        { 
            // Задача 3. Напишите рекурсивный метод, который принимает 
            // номер года и определяет, является ли он високосным или нет.

            Console.WriteLine("Введите год");
            double year = Convert.ToDouble(Console.ReadLine());
          
            Recursion();

            void Recursion()
            {

                if (year-4 >= 4) 
                {
                    year-=4; 
                    Recursion();
                }

                else
                {
                    if (year-4 == 0)
                    {
                        Console.WriteLine("Год високосный");
                        return;
                    }

                    else 
                    {
                        Console.WriteLine("Год невисокосный");
                        return;    
                    }
                
                }
                


            }

        }

    }
}