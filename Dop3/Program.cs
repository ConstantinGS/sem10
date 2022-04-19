using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        { //Дан массив, состоящий из случайных целых чисел. 
        // Дано число M. Выведите случайное подмножество массива, 
        // сумма элементов в котором не превосходит M.

            var rand = new Random();
            int[] array = new int [10];
            int count = 0;
            int count_2 = 0;
            Console.WriteLine($" Введите число");
            int M = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int resp = 0;


            Array_New();
            Dop3();


             void Array_New()
            {
                if (count<10)
                {
                    array[count] = rand.Next(0, 15);
                    Console.Write($"  {array[count]} ");
                    count++;
                    Array_New();
                }
                else return;                                             
            }

             void Print_New(int q)
            {
                if (count_2<q)
                {
                    Console.Write($"  {array[count_2]}  ");
                    count_2++;
                    Array_New();
                }
                else return;                                             
            }

            void Dop3()
            {
                resp = rand.Next(1, 10);
                int Dop3_Resp()
                    {
                        if(count<resp)
                        {
                            sum+=array[count];
                            count++;
                            return Dop3_Resp();
                        }
                        else return sum;
                    }



                if(Dop3_Resp()<M)
                {
                    Print_New(resp);
                    return;
                }
                else Dop3();




            }



            
           




        }

    }
}
 

