using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManLibrary
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменник не може бути нульовим.");
            }

            Numerator = numerator;
            Denominator = denominator;
        }

        public static Fraction operator +(Fraction f)
        {
            return f;
        }

        public static Fraction operator -(Fraction f)
        {
            return new Fraction(-f.Numerator, f.Denominator);
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
            int denominator = f1.Denominator * f2.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int numerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;
            int denominator = f1.Denominator * f2.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            int numerator = f1.Numerator * f2.Numerator;
            int denominator = f1.Denominator * f2.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            if (f2.Numerator == 0)
            {
                throw new DivideByZeroException("Ділення на нуль неможливе!");
            }
            int numerator = f1.Numerator * f2.Denominator;
            int denominator = f1.Denominator * f2.Numerator;
            return new Fraction(numerator, denominator);
        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            return f1.Numerator * f2.Denominator < f2.Numerator * f1.Denominator;
        }

        public static bool operator >(Fraction f1, Fraction f2)
        {
            return f1.Numerator * f2.Denominator > f2.Numerator * f1.Denominator;
        }

        public static bool operator >=(Fraction f1, Fraction f2)
        {
            return f1.Numerator * f2.Denominator >= f2.Numerator * f1.Denominator;
        }

        public static bool operator <=(Fraction f1, Fraction f2)
        {
            return f1.Numerator * f2.Denominator <= f2.Numerator * f1.Denominator;
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1.Numerator * f2.Denominator == f2.Numerator * f1.Denominator;
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }

        public static explicit operator double(Fraction f)
        {
            if (f.Denominator == 0)
            {
                throw new DivideByZeroException("Ділення на нуль неможливе при перетворенні в double!");
            }
            return (double)f.Numerator / f.Denominator;
        }

        public void Simplify()
        {
            int gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
