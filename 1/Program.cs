using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bwee
{
    class Fraction
    {
        public float fraction;
        public long numerator;
        public long denominator;
        public Fraction(float fraction, long numerator, long denominator)
        {
            this.fraction = fraction;
            this.numerator = numerator;
            this.denominator = denominator;
            Cut();
        }
        public void Cut()
        {
            long a = this.numerator;
            long b = this.denominator;
            while (a != 0 && b!= 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            long cut = a + b;
            numerator /= cut;
            denominator /= cut;
        }

        public static explicit operator Fraction(float number)
        {
            if (number % 1 == 0)
                return new Fraction(0, (long)number, 1);

            float decimals = number.ToString().Split(',')[1].Length;
            long den = (long)Math.Pow(10, decimals%11);
            long num = (long)(number * den);
            return new Fraction(0, num, den);
        }

        public static implicit operator float(Fraction number)
        {
            return ((float)(number.numerator) + number.fraction * number.denominator) / number.denominator;
        }

        public static Fraction operator + (Fraction f1, Fraction f2)
        {
            var f3 = new Fraction(0,1,1);
            f3.numerator = f1.numerator*f2.denominator + f2.numerator*f1.denominator;
            f3.denominator = f1.denominator * f2.denominator;
            return f3;
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            f2.numerator *= -1;
            return f1 + f2;
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            var f3 = new Fraction(0,1,1);
            f3.numerator = f1.numerator * f2.numerator;
            f3.denominator = f1.denominator * f2.denominator;
            return f3;
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            long num_b = f2.numerator;
            f2.numerator = f2.denominator;
            f2.denominator = num_b;

            return f1 * f2;
        }

        public void Print()
        {
            Console.WriteLine($"{numerator}/{denominator}");
        }
    }

    class ComplexNumber
    {
        public float real;
        public float imaginary;
        public ComplexNumber(float real, float imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        static public ComplexNumber operator +(ComplexNumber n1, ComplexNumber n2)
        {
            return new ComplexNumber(n1.real + n2.real, n1.imaginary + n2.imaginary);
        }

        static public ComplexNumber operator -(ComplexNumber n1, ComplexNumber n2)
        {
            n2.real *= -1;
            n2.imaginary *= -1;
            return n1 + n2;
        }

        static public ComplexNumber operator *(ComplexNumber n1, ComplexNumber n2)
        {
            var n3 = new ComplexNumber(0, 0);
            n3.real = n1.real * n2.real - n1.imaginary*n2.imaginary;
            n3.imaginary = n1.real * n2.imaginary + n2.real * n1.imaginary;
            return n3;
        }

        static public ComplexNumber operator /(ComplexNumber n1, ComplexNumber n2)
        {
            float denominator = (n2 * new ComplexNumber(n2.real, -n2.imaginary)).real;
            n2.imaginary *= -1;
            var n3 = n1 * n2;
            n3.real = (float)Math.Round(n3.real/denominator, 1);
            n3.imaginary = (float)Math.Round(n3.imaginary / denominator, 1);
            return n3;
        }

        public string toString()
        {
            string symb = imaginary >= 0 ? "+" : "";
            return $"{this.real} {symb}{imaginary}i";
        }

        static public ComplexNumber toComplex(string str)
        {
            var n = new ComplexNumber(0, 0);
            n.real = Int32.Parse(str.Split(' ')[0]);
            n.imaginary= Int32.Parse(str.Split(' ')[1].Trim('i'));
            return n;
        }
    }

    class myDate
    {
        public int year;
        public int month;
        public int day;
        public myDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        ~myDate()
        {
            Console.WriteLine("myDate Deleted");
        }

        static public myDate operator +(myDate d1, myDate d2)
        {
            int add_m = (int)Math.Floor((d1.day + d2.day) / 31.0);
            int add_y = (int)Math.Floor((d1.month + d2.month + add_m) / 12.0);
            int y = add_y + d1.year + d2.year;
            return new myDate(y, (d1.month + d2.month + add_m) % 12, (d1.day + d2.day) % 31);
        }

        static public myDate operator -(myDate d1, myDate d2)
        {
            int d = d1.day - d2.day;
            int min_m = (int)Math.Floor(d / 31.0);
            int m = d1.month - d2.month + min_m;
            int min_y = (int)Math.Floor(m / 12.0);
            int y = d1.year - d2.year + min_y;
            d = d <= 0 ? 31 + d : d;
            m = m <= 0 ? 12 + m : m;
            return new myDate(Math.Max(0, y), m, d);
        }

        public string toString()
        {
            return $"{year}/{month}/{day}";
        }
        static public myDate toDate(string str)
        {
            List<int> v = Array.ConvertAll(str.Split('/').ToArray(), int.Parse).ToList();
            return new myDate(v[0], v[1], v[2]);
        }

        static public implicit operator int(myDate d)
        {
            return (d.year*12+d.month)*31+d.day;
        }
    }

    class myTime
    {
        public int h, m, s;
        public myTime(int h, int m, int s)
        {
            this.h = h;
            this.m = m;
            this.s = s;
        }

        static public myTime operator +(myTime t1, myTime t2)
        {
            return new myTime(t1.h + t2.h, t1.m + t2.m, t1.s + t2.s);
        }

        static public myTime operator -(myTime t1, myTime t2)
        {
            int s = t1.s - t2.s;
            int min_m = (int)Math.Floor(s / 60.0);
            int m = t1.m - t2.m + min_m;
            int min_h = (int)Math.Floor(m / 60.0);
            int h = Math.Max(0, t1.h - t2.h + min_h);
            s = s <= 0 ? 60 * -min_m + s : s;
            m = m <= 0 ? 60 * -min_h + m : m;
            return new myTime(h, m, s);
        }

        public string toString()
        {
            return $"{(h > 9 ? h : "0" + h)}:{(m > 9 ? m : "0" + m)}:{(s > 9 ? s : "0" + s)}";
        }
        static public myTime toTime(string str)
        {
            List<int> v = Array.ConvertAll(str.Split(':').ToArray(), int.Parse).ToList();
            return new myTime(v[0], v[1], v[2]);
        }

        ~myTime()
        {
            Console.WriteLine("myTime deleted");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(0, 100, 45);
            Fraction f2 = (Fraction)10.4;
            Fraction f3 = f1 + f2;
            f1.Print();
            f2.Print();
            Console.WriteLine(f1 > f2);

            ComplexNumber c1 = new ComplexNumber(2, 3);
            ComplexNumber c2 = new ComplexNumber(4, -5);
            ComplexNumber c3 = ComplexNumber.toComplex("2 +4i");

            Console.WriteLine(c1.toString());
            Console.WriteLine(c2.toString());
            Console.WriteLine((c1 / c2).toString());
            Console.WriteLine(c3.toString());

            myDate d1 = new myDate(1995, 9, 12);
            myDate d2 = new myDate(0,0, 31);
            myDate d3 = myDate.toDate("2022/12/11");

            Console.WriteLine((d1 - d2).toString());
            Console.WriteLine(d3.toString());
            Console.WriteLine(d1 < d3);

            myTime t1 = myTime.toTime("1:1:35");
            myTime t2 = myTime.toTime("0:0:150");

            Console.WriteLine((t1 - t2).toString());

            Console.ReadLine();
        }
    }
}
