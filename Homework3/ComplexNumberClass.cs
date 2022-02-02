using System;
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

        #region Math
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
        #endregion Math
        //Вывод на консоль
        public override string ToString()
        {
            if (im < 0) return $"{re} - {Math.Abs(im)}i";

            else return $"{re} + {im}i";
        }

    }
    class ComplexNumberClass
    {
        static void Main(string[] args)
        {
            #region set coplex
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
            #endregion set complex

            #region Menu
            Console.WriteLine("Actions for complex numbers");
            Console.WriteLine("===================");
            Console.WriteLine("1 -> Plus");
            Console.WriteLine("2 -> Minus");
            Console.WriteLine("3 -> Product");
            Console.WriteLine("0 -> Quit");
            Console.WriteLine("===================");

            bool isInMenu = true;

            while (isInMenu)
            {

                Console.Write("Enter the number of action ");
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 0:
                        isInMenu = false;
                        break;

                    case 1:
                        Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} = {complex01.Plus(complex02)}");
                        break;

                    case 2:
                        Console.WriteLine($"Разность комплексных чисел = {complex01.Minus(complex02)}");
                        break;
                    case 3:
                        Console.WriteLine($"Произведение комплексных чисел = {complex01.Product(complex02)}");
                        break;

                    default:
                        Console.WriteLine("No action chosen");
                        break;
                }

                #endregion Menu

                Console.ReadLine();
            }
        }
    }
}