using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{

    class Fraction
    {

      #region variables and properties
      //Числитель, знаеменатель, целая часть
      private int numerator;
      private  int denominator;
      private int integerPart;
      private double decimalPart;
      
        public int Numerator
        {
            set
            {
                numerator = value;
            }

            get
            {
                return numerator;
            }

        }

        public int Denominator
        {
            
            set
            {
                if (value == 0) throw new ArgumentException("Cannot devide by 0!");

                denominator = value;
            }

            get
            {
                return denominator;
            }
        }
        
        //Если я все правильно понимаю, то без сеттера будет только на чтение
        public double DecimalFraction
        {
            get {

                decimalPart = Convert.ToDouble (numerator) /Convert.ToDouble (denominator);
                return decimalPart;
            }
        }

        #endregion variables and properties

        public Fraction (int numerator, int denominator, int integerPart)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Cannot devide by 0!");
            }

            this.numerator = numerator;
            this.denominator = denominator;
            this.integerPart = integerPart;
        }

        #region Math
        public Fraction SimplifyFraction()
        {
            if (numerator > denominator)
            {
                for (int i = numerator ; i > 0; i--)
                {
                    if (numerator % i == 0 & denominator % i == 0)
                    {
                        numerator /= i;
                        denominator /= i;

                        continue;
                    }
                }

                return new Fraction(numerator % denominator, denominator, numerator / denominator);

            }
            else
            {

                integerPart = 0;

                for (int i = numerator ; i > 0; i--)
                {
                    if (numerator % i == 0 & denominator % i == 0)
                    {
                        numerator /= i;
                        denominator /= i;

                        continue;
                    }
                }
            }
                return new Fraction(numerator, denominator, integerPart);
        }

        public Fraction Plus(Fraction x)
        {
          
            return new Fraction(numerator * x.denominator+ x.numerator * denominator, denominator*x.denominator , integerPart+x.integerPart);
        }

        public Fraction Subtraction(Fraction x)
        {
            return new Fraction(numerator * x.denominator - x.numerator * denominator, denominator * x.denominator, integerPart - x.integerPart);
        }

        public Fraction Product(Fraction x)
        {
            return new Fraction(numerator * x.numerator, denominator * x.denominator, integerPart * x.integerPart);
        }

        public Fraction Devision(Fraction x)
        {
            if (integerPart > 0 & x.integerPart > 0)
            {
                numerator = integerPart * denominator + numerator;
                x.numerator = x.integerPart * denominator + x.numerator;
                return new Fraction(numerator * x.denominator, denominator * x.numerator, 0);
            }

            return new Fraction(numerator * x.denominator, denominator * x.numerator, integerPart);
        }

        #endregion Math

        public override string ToString()
        {

            if (integerPart <= 0) return $"Fraction is {numerator}/{denominator}";


            else if (denominator == 1) return $"You have new integer number: {integerPart} and no fraction";

            else return $"Integer part is {integerPart} and fraction is  {numerator}/{denominator}";
        }


    }

    class FractionWork
    {
        static void Main(string[] args)
        {


            Fraction fraction01 = new Fraction(1, 1, 0);
            Console.Write("Enter first fraction numerator value:");
            fraction01.Numerator = int.Parse(Console.ReadLine());
            Console.Write("Enter first fraction denominator value:");
            fraction01.Denominator = int.Parse(Console.ReadLine());

            Console.WriteLine(fraction01);

            Console.WriteLine($"In decimal it's {fraction01.DecimalFraction}");

                Fraction fraction02 = new Fraction(1, 1, 0);
                Console.Write("Enter second fraction numerator value:");
                fraction02.Numerator = int.Parse(Console.ReadLine());
                Console.Write("Enter second fraction denominator value:");
                fraction02.Denominator = int.Parse(Console.ReadLine());
           
            Console.WriteLine(fraction02);

            Console.WriteLine($"In decimal it's {fraction02.DecimalFraction}");

            //Цикл стоит здесь, потому что я не хочу заставлять пользователя постоянно вводить разные значения дробей
            #region Menu
            Console.WriteLine("Actions for fractions");
                Console.WriteLine("===================");
                Console.WriteLine("1 -> Plus");
                Console.WriteLine("2 -> Subtraction");
                Console.WriteLine("3 -> Product");
                Console.WriteLine("4 -> Devision");
                Console.WriteLine("0 -> Quit");
                Console.WriteLine("==================="); 
            
            bool isWorking = true;

            while (isWorking)
            {
                Console.Write("Enter action number ");

                int number = int.Parse(Console.ReadLine());

                switch (number)
                {

                    case 1:

                        Fraction fractionResult = fraction01.Plus(fraction02);
                        Console.WriteLine($"The summ of two fractions is {fractionResult}");

                        Console.Write("Press 5 to simplify fracion or Enter to go to previous menu ");
                        int number1 = int.Parse(Console.ReadLine());
                        switch (number1)
                        {
                            case 5:
                                Console.WriteLine($"{fractionResult.SimplifyFraction()}");
                                break;

                            default: break;
                        }

                        break;

                    case 2:
                       Fraction fractionResult1 = fraction01.Subtraction(fraction02);
                       Console.WriteLine($"The difference between two fractions is {fractionResult1}");

                       Console.Write("Press 5 to simplify fracion or Enter to go to previous menu ");
                        int number2 = int.Parse(Console.ReadLine());
                        switch (number2)
                        {
                            case 5:
                                Console.WriteLine($"{fractionResult1.SimplifyFraction()}");
                                break;

                            default: break;
                        }

                        break;

                    case 3:
                        Fraction productResult = fraction01.Product(fraction02);
                        Console.WriteLine($"The product of two fractions is {productResult}");

                        Console.Write("Press 5 to simplify fracion or Enter to go to previous menu ");
                        int number3 = int.Parse(Console.ReadLine());

                        switch (number3)
                        {
                            case 5:
                                Console.WriteLine($"{productResult.SimplifyFraction()}");
                                break;

                            default: break;
                        }

                        break;

                    case 4:
                        Fraction devisionResult = fraction01.Devision(fraction02);
                        Console.WriteLine($" The result is {devisionResult}");
                        Console.Write("Press 5 to simplify fracion or Enter to go to previous menu ");
                        int number4 = int.Parse(Console.ReadLine());

                        switch (number4)
                        {
                            case 5:
                                Console.WriteLine($"{devisionResult.SimplifyFraction()}");
                                break;

                            default: break;
                        }

                        break;

                    case 0: isWorking = false;
                        break;

                    default:
                        Console.WriteLine("Incorrect input. Try again");
                        break;

                }
              #endregion Menu

                Console.ReadLine();
            }
        }
    }
}
