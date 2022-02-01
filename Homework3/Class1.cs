﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3

{
    class ComplexClass
    {
        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private double im;

        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        private double re;

        #region Properties
        public double Re
        {
            get
            {
                return re;

            }
            set
            {
                re = value;
            }
        }

        //убрал ненужное здесь исключение
        public double Im
        {
            get
            {
                return im;

            }
            set
            {
                im = value;
            }
        }
        #endregion Properties

        //убрал ненужное исключение
        public ComplexClass(double re, double im)
        {

            this.re = re;
            this.im = im;
        }

        //Добавил математику, переписал структуры на класс
        public ComplexClass Plus(ComplexClass x)
        {
            return new ComplexClass(re + x.re, im + x.im);
        }

        public ComplexClass Minus(ComplexClass x)
        {
            return new ComplexClass(re - x.re, im - x.im);
        }

        public ComplexClass Product(ComplexClass x)

        {
            return new ComplexClass((re * x.re - im * x.im), (re * x.im + im * x.re));
        }
        
        //Вывод на консоль
        public override string ToString()
        {
            if (im < 0) return $"{re} - {Math.Abs(im)}i";

            else return $"{re} + {im}i";
        }

    }
        class Class1
     {
        static void Main(string[] args)
        {
            ComplexClass complex01 = new ComplexClass(5, 3);

            //Добавил возможность менять число через свойста
            Console.Write("(1) Введите действительную часть комплексного числа: ");
            complex01.Re = double.Parse(Console.ReadLine());
            Console.Write("(1) Введите мнимую часть комплексного числа: ");
            complex01.Im = double.Parse(Console.ReadLine());
           
            
            ComplexClass complex02 = new ComplexClass(3, -1);
            Console.Write("(2) Введите действительную часть комплексного числа: ");
            complex02.Re = double.Parse(Console.ReadLine());
            Console.Write("(2) Введите мнимую часть комплексного числа: ");
            complex02.Im = double.Parse(Console.ReadLine());

            Console.WriteLine($"Первое комплексное число: {complex01}");
            Console.WriteLine($"Второе комплексное число: {complex02}");


            Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} = {complex01.Plus(complex02)}");
            Console.WriteLine($"Разность комплексных чисел = {complex01.Minus(complex02)}");
            Console.WriteLine($"Произведение комплексных чисел = {complex01.Product(complex02)}");

            Console.ReadLine();
        }
    }
}
