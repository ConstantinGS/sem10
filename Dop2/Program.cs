using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        { // Дана последовательность натуральных чисел. 
        // Определите значение второго по величине элемента в этой последовательности.


            var rand = new Random();
            int[] array = new int [10];
            int count = 0;
            int count_2 = 0;


            Array_New();
            count = 0;
            Console.WriteLine();
            Sort();
            count = array.Length-1;
            Second_max();


              
            


            void Second_max()
            {
                if (array[count-1]<array[count])
                {
                    Console.WriteLine($"  {array[count-1]}  ");
                    return; 
                }
                else 
                {
                    count--;
                    Second_max();

                }

            }

            void Sort()
            {
                if (count_2<9)
                {
                    if (count<9)
                    {
                        if (array[count] > array[count+1] )
                        {
                        (array[count], array[count+1]) = (array[count+1], array[count]) ;
                        } 
                            count++;
                            Sort();
                    }
                    else 
                    {
                        count = 0;
                        count_2++;
                        Sort();
                    }
                }
                else  return;                                                   
            }

  
            void Array_New()
            {
                if (count<10)
                {
                    array[count] = rand.Next(0, 15);
                    Console.Write($"  {array[count]}  ");
                    count++;
                    Array_New();
                }
                else return;                                             
            }




        }

    }
}