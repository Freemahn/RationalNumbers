using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(3, 4);
            Rational r2 = new Rational(5, 3);
            Console.WriteLine(r1 + r2);
            Console.WriteLine(r1 - r2);
            Console.WriteLine(r1 * r2);
            Console.WriteLine(r1 / r2);
            return;
        }
    }
    public class Rational
    {
        int numerator { get; set; }
    
        int denomenator { get; set; }

        public Rational(int numerator, int denomenator)
        {
            this.numerator = numerator;
            this.denomenator = denomenator;
        }


        public override string ToString()
        {
            return numerator + "/" + denomenator;
        }

        public  double ToDouble()
        {
            return (double)numerator / (double)denomenator;
        }

        public static Rational operator +(Rational r1, Rational r2)
        {
            return new Rational(r1.numerator * r2.denomenator + r2.numerator * r1.denomenator, r1.denomenator * r2.denomenator);
        }
        public static Rational operator -(Rational r1, Rational r2)
        {
            return new Rational(r1.numerator * r2.denomenator - r2.numerator * r1.denomenator, r1.denomenator * r2.denomenator);
        }
        public static Rational operator *(Rational r1, Rational r2)
        {
            return new Rational(r1.numerator * r2.numerator, r1.denomenator * r2.denomenator);
        }
        public static Rational operator /(Rational r1, Rational r2)
        {
            return new Rational(r1.numerator * r2.denomenator, r1.denomenator * r2.numerator);
        }
        public override bool Equals(System.Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Point return false.
            Rational p = obj as Rational;
            if ((System.Object)p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (numerator == p.numerator) && (denomenator == p.denomenator);
        }
        public override int GetHashCode()
        {
            return numerator ^ denomenator;
        }

        private static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }

            return a + b;
        }
        public static Rational Normalize(Rational a)
        {
            int gcd = GCD(a.numerator, a.denomenator);
            return new Rational(a.numerator / gcd, a.denomenator / gcd);
        }
        public static explicit operator double(Rational a)
        {
            return (double)a.numerator / (double)a.denomenator;
        }
        public static explicit operator decimal(Rational a)
        {
            return (decimal)a.numerator / (decimal)a.denomenator;
        }




    }
    
}
