using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        { 
            // Задача 2. Двумерный массив заполнен случайными натуральными числами от 1 до 10.
            // Найдите количество элементов, значение которых больше 5, и их сумму.


            int[,] array = new int[4,4];
            var rand = new Random();
            int count = 0;
            int count_2 = 0;
            int sum = 0;
            int q = 0;


            Recursion();


            void Recursion()
            {

                if (count<4)
                {
                    if (count_2<4)
                    {
                        array[count, count_2] = rand.Next(1, 10);
                        Console.Write($"  {array[count, count_2]}  ");
                        if (array[count, count_2]>5)
                        {
                            sum+=array[count, count_2];
                            q++;
                            
                        }
                        count_2++;
                        Recursion();
                    }
                    else
                    {
                        Console.WriteLine();
                        count++;
                        count_2 = 0;
                        Recursion();

                    }
 
                }

                else 
                {
                    Console.WriteLine($" Сумма {sum}");
                    Console.WriteLine($" Количество {q}");

                    return;
                }
               
            }


            
        }

    }
}