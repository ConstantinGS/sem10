using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        { //Дана монотонная последовательность, в которой каждое натуральное 
        //число n встречается ровно n раз: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... 
        //Дано число m. Выведите первые m членов этой последовательности.
            
            
            int count = 1;
            int counter = 0;
            int counter_2 = 0;
            Console.WriteLine("Введите число");
            int m = Convert.ToInt32(Console.ReadLine()); 
            Recursion();


            void Recursion()
            {
                if (count<=m)
                {
                    if (counter < count)
                    {
                        if (counter_2<m)
                        {
                            Console.WriteLine(count);
                            counter_2++;

                        }

                        

                        counter++;
                        
                    }
                    else
                    {
                        counter = 0;
                        count++;
                    }
                Recursion();



                }
                else return;
               
            }

           


 



        }

    }
}