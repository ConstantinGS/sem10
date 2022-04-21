using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        { 
            // Задача 1. На вход подуются два числа n и m, 
            // такие, что n<m. Заполните массив случайными числами из промежутка [n, m].


            int[] array = new int[10];
            Console.WriteLine("Введите числа");
            Recursion();


            void Recursion()
            {

                int n = Convert.ToInt32(Console.ReadLine());
                int m = Convert.ToInt32(Console.ReadLine());


                if (n>=m)
                {
                    Console.WriteLine("Числа введены неверно. Введите заново.");
                    Recursion();
                }

                else 
                {
                    var rand = new Random();
                    int count = 0;
                    void Recursion_2()
                    {
                        if (count<10)
                        {
                            array[count] = rand.Next(n,m);
                            Console.Write($"  {array[count]}  ");
                            count++;
                            Recursion_2();
                        }
                        else return;
                    }
                    Recursion_2();
                    return;

                }
            }



            
        }

    }
}