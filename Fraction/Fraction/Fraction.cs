using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction_
{
    internal class Fraction
    {
        public int denominator { get; }
        public int numerator { get; }
        public Fraction(Int32 dividend, Int32 divider)
        {
            this.denominator = dividend * (divider >= 0 ? 1 : -1);
            this.numerator = divider * (divider >= 0 ? 1 : -1);
        }

        public static Fraction operator +(Fraction A, Fraction B)
        {
            if (A.numerator == B.numerator) 
                return new Fraction(A.denominator + B.denominator, A.numerator);

            else if (A.numerator % B.numerator == 0 || B.numerator % A.numerator == 0)
            {
                return new Fraction(A.denominator * (B.numerator / A.numerator == 0 ? 1 : B.numerator / A.numerator) +
                                   B.denominator * (A.numerator / B.numerator == 0 ? 1 : A.numerator / B.numerator),
                                   (A.numerator > B.numerator ? A.numerator : B.numerator));
            }
            return new Fraction(A.denominator * B.numerator + B.denominator * A.numerator,
                A.numerator * B.numerator);
        }
        public static Fraction operator -(Fraction A, Fraction B)
        {
            if (A.numerator == B.numerator) 
                return new Fraction(A.denominator - B.denominator, A.numerator);
            else if (A.numerator % B.numerator == 0 || B.numerator % A.numerator == 0)
            {
                return new Fraction(A.denominator * (B.numerator / A.numerator == 0 ? 1 : B.numerator / A.numerator) -
                                   B.denominator * (A.numerator / B.numerator == 0 ? 1 : A.numerator / B.numerator),
                                   (A.numerator > B.numerator ? A.numerator : B.numerator));
            }
            return new Fraction(A.denominator * B.denominator - B.denominator * A.denominator,
                A.denominator * B.denominator);
        }
        public static Fraction operator *(Fraction A, Fraction B) => 
            new Fraction(A.denominator * B.denominator, A.numerator * B.numerator);
        public static Fraction operator /(Fraction A, Fraction B) =>
            new Fraction(A.denominator * B.numerator, A.numerator * B.denominator);
        public static bool operator >(Fraction A, Fraction B) =>
            ((Single)A.denominator / (Single)A.numerator > B.denominator / (Single)B.numerator);
        public static bool operator <(Fraction A, Fraction B) => 
            ((Single)A.denominator / (Single)A.numerator < B.denominator / (Single)B.numerator);
        public static bool operator ==(Fraction A, Fraction B) => 
            ((Single)A.denominator / (Single)A.numerator == B.denominator / (Single)B.numerator);
        public static bool operator !=(Fraction A, Fraction B) => 
            ((Single)A.denominator / (Single)A.numerator != B.denominator / (Single)B.numerator);



        public override bool Equals(object? obj) => obj is Fraction Fraction &&
                  (Single)this.denominator / (Single)this.numerator == (Single)Fraction.denominator / (Single)Fraction.numerator;
        public override string ToString() 
            => $"({this.denominator / this.numerator}) {this.denominator % this.numerator}/{this.numerator}";
    }
}
