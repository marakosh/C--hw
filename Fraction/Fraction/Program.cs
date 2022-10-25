namespace Fraction_
{
    class Program
    {
        public static Fraction solution_fraction(char solution, ref Fraction A, Fraction B) => solution switch
        {
            '*' => A *= B,
            '/' => A /= B,
            '+' => A += B,
            _ => A -= B
        };

        public static void Main()
        {
            Console.Write("enter dividend 1 : ");
            Int32 denominator1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter divider 1 : ");
            Int32 numerator1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter dividend 2 : ");
            Int32 denominator2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter divider 2 : ");
            Int32 numerator2 = Convert.ToInt32(Console.ReadLine());
            Fraction A = new Fraction(denominator1, numerator1);
            Fraction B = new Fraction(denominator2, numerator2);
            Console.Write("enter ( * / + - ) : ");
            Char select = Convert.ToChar(Console.Read());
            solution_fraction(solution: select, A: ref A, B: B);
            Console.WriteLine(A);
        }
    }
}

