using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        { // Дано натуральное число n > 1. Вывести все простые множители данного числа.
            
            
            int count = 2;
            int count_2 = 2;
            Console.WriteLine("Введите число");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Все возможные простые числа:"); 
            Recursion();
            Console.WriteLine("Разложение на множители:"); 
            Recursion2();


            void Recursion()
            {
                if (count<10)
                {
                    if (m%count==0) Console.WriteLine(count);
                    count++;
                    Recursion();
                }
                else return;
            }

            void Recursion2()
            {
                if (count_2<10)
                {
                    if (m%count_2==0) 
                    {
                        Console.WriteLine(count_2);
                        m/=count_2;       
                    }
                    else
                    {
                        count_2++;
                    }



                    
                    Recursion2();
                }
                else return;
            }




        }

    }
}