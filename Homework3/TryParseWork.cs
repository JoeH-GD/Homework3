using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class TryParseWork
    {
        static void Main(string[] args)
        {
            Console.Title = "SummOddNumbers";
            Console.WriteLine("Халдон. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.\n " +
                "Числа и сумму вывести на экран с помощью метода TryParse\n");

            int summ = 0;
            int x = 0;
           

            Console.WriteLine("Enter any number");

            do
            {

                //А вот и метод TryParse. В самом низу живет else, который сообщает о некорректном вводе и закрытии программы
                if (int.TryParse(Console.ReadLine(), out x))
                {

                    #region NumToSum    
                    //Использовано сокращенное "И" потому что при несблюдении любого условия число нас не неинтересует
                    //Экономим на вычислениях
                    if (x % 2 != 0 && x > 0)
                    {
                        Console.WriteLine("You have entered an odd number {0}. It will be added.", x);
                        summ = summ + x;


                    }
                    #endregion NumToSum

                    #region numToIgnore

                    else if (x < 0 || (x % 2 == 0 && x != 0))

                    {

                        Console.WriteLine("You have entered an even or a negative number{0}. Enter another number", x);

                    }
                    #endregion numToIgnore

                    #region Exit
                    else
                    {
                        Console.WriteLine("You've entered 0 - the count is finished. Result {0}", summ);
                    }
                    #endregion Exit
                }

                else
                {
                    Console.WriteLine ("Incorrect input! Quitting calculation.");
                }
            }

            while (x != 0);

            Console.ReadLine();
        }
    }
}
