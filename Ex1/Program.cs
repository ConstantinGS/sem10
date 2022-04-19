using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        { //Дано число n. Получите число, записанное в обратном порядке.
            
            
            int count = 0;
            int buffer = 0;
            string new_number = ""; 
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine()); 
            Recursion();


            void Recursion()
            {
                if (n/10>0)
                {   
                    new_number+=n%10;
                    n/=10;
                    Recursion();
                }
                else 
                {
                    new_number+=n;
                    Console.WriteLine(new_number);
                    return;
                }
               
            }

           


 



        }

    }
}