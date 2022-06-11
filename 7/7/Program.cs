using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        class Bus : IComparable
        {
            public double mass;
            public override string ToString()
            {
                return mass.ToString();
            }
            public Bus(double mass)
            {
                this.mass = mass;
            }
            public int CompareTo(object obj)
            {
                return mass.CompareTo(((Bus)obj).mass);
            }
            public static bool operator >(Bus b1, Bus b2)
            {
                return b1.CompareTo(b2) == 1;
            }

            public static bool operator <(Bus b1, Bus b2)
            {
                return b1.CompareTo(b2) == -1;
            }

            public static bool operator >=(Bus b1, Bus b2)
            {
                return b1.CompareTo(b2) == 1 || b1.CompareTo(b2) == 0;
            }

            public static bool operator <=(Bus b1, Bus b2)
            {
                return b1.CompareTo(b2) == -1 || b1.CompareTo(b2) == 0;
            }

            public static bool operator ==(Bus b1, Bus b2)
            {
                return b1.CompareTo(b2) == 0;
            }

            public static bool operator !=(Bus b1, Bus b2)
            {
                return b1.CompareTo(b2) != 0;
            }
        }
        public static List<int> Sort(List<int> list, bool asc = true)
        {
            bool change = false;
            do
            {
                change = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    Predicate<int> compare = asc ?
                    (left) => list[i] > left :
                    (left) => list[i] < left;
                    if (compare(list[i + 1]))
                    {
                        int a = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = a;
                        change = true;
                    }
                }
            } while (change);
            return list;
        }

        public static List<T> Sort<T>(List<T> list, bool asc = true) where T : IComparable
        {
            bool change = false;
            do
            {
                change = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    bool ifi = (Convert.ToInt32(asc) * 2 - 1) * list[i].CompareTo(list[i + 1]) > 0;
                    if (ifi)
                    {
                        T a = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = a;
                        change = true;
                    }
                }
            } while (change);
            return list;
        }

        public static void PrintList<T>(List<T> l)
        {
            Console.WriteLine();
            l.ForEach( (a) => Console.Write(a.ToString()+" "));
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Initialize array's...");
            List<int> num = new List<int>() { 2, 3, 423, -1, 14 };
            List<string> strings = new List<string>() { "ab", "aa", "1c" };
            List<double> f = new List<double>() { 1.1, -7.8, 99.99, 13.45 };
            List<Bus> b = new List<Bus>() { new Bus(15.3), new Bus(10), new Bus(12), new Bus(17) };
            Console.WriteLine("Done!\n\n");

            Console.Write("num array (int):");
            PrintList<int>(num);
            Console.Write("strings array (string):");
            PrintList<string>(strings);
            Console.Write("f array (double):");
            PrintList<double>(f);
            Console.Write("b array (Bus):");
            PrintList<Bus>(b);

            Console.WriteLine("\n\nStart sort array's...");
            num = Sort(num);
            strings = Sort<string>(strings);
            f = Sort<double>(f, false);
            b = Sort<Bus>(b);
            Console.WriteLine("Done!\n\n");

            Console.Write("num array (int):");
            PrintList<int>(num);
            Console.Write("strings array (string):");
            PrintList<string>(strings);
            Console.Write("f array (double):");
            PrintList<double>(f);
            Console.Write("b array (Bus):");
            PrintList<Bus>(b);

            Console.ReadLine();
        }
    }
}
