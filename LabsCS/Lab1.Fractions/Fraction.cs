using System;

namespace Lab1.Fractions
{
    public class Fraction
    {
        private Number Numerator { get; set; }

        private Number Denominator { get; set; }

        public Fraction()
        {
            Numerator = new Number();
            Denominator = new Number();
            Numerator.Num = 0;
            Denominator.Num = 1;
            Numerator.IsEven = true;
            Denominator.IsEven = false;
        }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0) throw new ArgumentException("Знаменатель не может равняться нулю");
            Numerator = new Number();
            Denominator = new Number();
            Numerator.Num = numerator;
            Denominator.Num = denominator;
            Numerator.IsEven = numerator % 2 == 0;
            Denominator.IsEven = denominator % 2 == 0;
        }

        public override string ToString() => Numerator.Num.ToString() + "/" + Denominator.Num.ToString();

        private void ReduceFraction()
        {
            int gcd = FindGreatestCommonDivisor(Numerator.Num, Denominator.Num);
            Numerator.Num /= gcd;
            Denominator.Num /= gcd;
        }

        private static int FindGreatestCommonDivisor(int a, int b) // НОД
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a % b == 0) return b;
            if (b % a == 0) return a;

            if (a > b) return FindGreatestCommonDivisor(a % b, b);
            return FindGreatestCommonDivisor(a, b % a);
        }

        private static int FindLeastCommonMultiple(int a, int b) // НОК
        {
            return (a * b) / FindGreatestCommonDivisor(a, b);
        }

        public static Fraction Addition(Fraction fr1, Fraction fr2)
        {
            Fraction res = new Fraction();
            res.Denominator.Num = FindLeastCommonMultiple(fr1.Denominator.Num, fr2.Denominator.Num);
            res.Denominator.IsEven = res.Denominator.Num % 2 == 0;

            res.Numerator.Num = fr1.Numerator.Num * (res.Denominator.Num / fr1.Denominator.Num) + fr2.Numerator.Num * (res.Denominator.Num / fr2.Denominator.Num);
            res.Numerator.IsEven = res.Numerator.Num % 2 == 0;

            res.ReduceFraction();

            return res;
        }

        public static Fraction Subtraction(Fraction fr1, Fraction fr2)
        {
            Fraction res = new Fraction();
            res.Denominator.Num = FindLeastCommonMultiple(fr1.Denominator.Num, fr2.Denominator.Num);
            res.Denominator.IsEven = res.Denominator.Num % 2 == 0;

            res.Numerator.Num = fr1.Numerator.Num * (res.Denominator.Num / fr1.Denominator.Num) - fr2.Numerator.Num * (res.Denominator.Num / fr2.Denominator.Num);
            res.Numerator.IsEven = res.Numerator.Num % 2 == 0;

            res.ReduceFraction();

            return res;
        }

        public static Fraction Multiplication(Fraction fr1, Fraction fr2)
        {
            Fraction res = new Fraction();
            res.Numerator.Num = fr1.Numerator.Num * fr2.Numerator.Num;
            res.Numerator.IsEven = res.Numerator.Num % 2 == 0;
            res.Denominator.Num = fr1.Denominator.Num * fr2.Denominator.Num;
            res.Denominator.IsEven = res.Denominator.Num % 2 == 0;
            res.ReduceFraction();
            return res;
        }

        public static Fraction Division(Fraction fr1, Fraction fr2)
        {
            Fraction res = new Fraction();
            res.Numerator.Num = fr1.Numerator.Num * fr2.Denominator.Num;
            res.Numerator.IsEven = res.Numerator.Num % 2 == 0;
            res.Denominator.Num = fr1.Denominator.Num * fr2.Numerator.Num;
            res.Denominator.IsEven = res.Denominator.Num % 2 == 0;
            res.ReduceFraction();
            return res;
        }
    }
}
