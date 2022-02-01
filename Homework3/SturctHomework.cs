using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    struct Complex
    {

        public double im;


        public double re;

        public Complex Plus(Complex x)
        {
            return new Complex(re + x.re, im + x.im);
        }

        public Complex Minus(Complex x)
        {
            return new Complex(re - x.re, im - x.im);
        }

        public Complex Product(Complex x)

        {
            return new Complex ((re * x.re - im * x.im),(re * x.im + im * x.re));
        }


        //Переписал в структуру конструктор, чтобы облегчить решение
        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        //Изменил вывод на более красивый
        public override string ToString()
        {
            if (im < 0) return $"{re} - {Math.Abs(im)}i";

            else return $"{re} + {im}i";

        }

    }

    class SturctHomework
    {
        static void Main(string[] args)
        {
            //Инициализировал 0, чтобы сократить и убрать лишние переменные
            Complex complex01 = new Complex(0,0);
            Console.Write("(1) Введите действительную часть комплексного числа: ");
            complex01.re = double.Parse(Console.ReadLine());
            Console.Write("(1) Введите мнимую часть комплексного числа: ");
            complex01.im = double.Parse(Console.ReadLine());

            //Объявляем и инициализируем второе комплексное число
            Complex complex02 = new Complex(0, 0);
            Console.Write("(2) Введите действительную часть комплексного числа: ");
            complex02.re = double.Parse(Console.ReadLine());
            Console.Write("(2) Введите мнимую часть комплексного числа: ");
            complex02.im = double.Parse(Console.ReadLine());


            Console.WriteLine($"Первое комплексное число: {complex01}");
            Console.WriteLine($"Второе комплексное число: {complex02}");


           //Вывод всех математических операций с комплексными числами
            Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} = {complex01.Plus(complex02)}");
            Console.WriteLine($"Разность комплексных чисел = {complex01.Minus(complex02)}");
            Console.WriteLine($"Произведение комплексных чисел = {complex01.Product(complex02)}");

            Console.ReadLine();
        }
    }
}
